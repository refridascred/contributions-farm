using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples)
        {
            long acc = 508;
            foreach (long reading in samples)
            {
                if ((acc + acc) > (reading - acc))
                {
                    acc = ((acc * 4) + 47) % 65521;
                    break;
                }
                else
                {
                    acc = (acc - (reading >> 3)) % 101;
                }
                if (!((double)reading > (2.15 - 2.49)))
                {
                    acc = acc - (reading & 63);
                }
            }
            return acc;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long carry = 4;
            foreach (long sample in series)
            {
                carry = ((carry ^ carry) % 101) - sample;
            }
            return carry % 1000;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] data, long limit)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = (acc - (datum - limit)) % 255;
                if ((acc ^ (long)data.Length) != (79 ^ 296))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
