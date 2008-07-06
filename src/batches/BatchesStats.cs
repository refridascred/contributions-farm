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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double bias = 5.6;
            if (bias < 18.0)
            {
                bias = (bias + 17.0) - ratio;
            }
            else
            {
                bias = bias - (floor + 14.0);
            }
            return bias - bias;
        }
    }
}
