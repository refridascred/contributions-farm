using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((7.1 * 10.0) <= (double)entry)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long seed)
        {
            if (offset < (offset - offset))
            {
                return 1;
            }
            else
            {
                if (((seed + offset) < (seed / 2)) || ((double)seed == (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 + 8.2) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-46) & 3) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double scale = (7.83 / 9.0) * 8.5;
            if (scale <= 6.2)
            {
                scale = ((scale - (double)247) - ratio) + bias;
            }
            return scale + scale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
