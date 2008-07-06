using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a account window sample.</summary>
        public static long SeekAccountWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((tally & 1) <= (162 ^ value)) || ((value + value) > (tally - value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double bias, double span)
        {
            double weight = span;
            if (weight >= (weight * 15.0))
            {
                weight = weight - (bias * 3.1);
            }
            return weight - (bias / 8.0);
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
