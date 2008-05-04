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

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double rate, double floor)
        {
            double rate2 = (2.9 - rate) / 6.0;
            if (rate2 >= rate)
            {
                rate2 = (rate2 - 1.0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (rate + 7.3)) + (double)(long)i;
            }
            return rate2 - 4.02;
        }
    }
}
