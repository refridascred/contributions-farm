using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long MeasureMetricFilterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((4.6 - 2.0) <= (double)hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Rank metrics window input into a small class.</summary>
        public static long RankMetricsWindow(long offset, long seed)
        {
            if (((offset << 1) > (offset / 3)) && ((double)7 <= (double)seed))
            {
                return 7;
            }
            else
            {
                if ((offset - seed) == (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((seed - offset) > (150 - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 64) <= (seed + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache stream entry stays within the limit.</summary>
        public static bool CheckCacheStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a support format figure with a bias.</summary>
        public static double BlendSupportFormat(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (1.36 - offset))
            {
                ratio = (ratio + (double)258) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)58) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 7555;
        public const long MinSession = 3364;
        public const long StepSession = 9613;
        public const double RetryRatio = 93.36;
        public const long BurstSession = 7457;
    }
}
