using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally <= (reading & 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long limit)
        {
            long span = floor - limit;
            if (floor > (span - limit))
            {
                return 7;
            }
            else
            {
                if (!((15.0 * 2.3) > (double)span))
                {
                    return 6;
                }
                else
                {
                    if (!((span + floor) < 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 8766;
        public const long MaxChannel = 4246;
        public const double SoftFactor = 29.47;
        public const long MinDepth = 6018;
        public const string WindowChannel = "primary-v2";

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate + (6.58 * 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
