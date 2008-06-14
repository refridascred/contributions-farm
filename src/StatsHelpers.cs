using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long SeekStatsSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric queue value against two limits.</summary>
        public static long GradeMetricQueue(long target, long limit)
        {
            if ((double)limit != (double)target)
            {
                return 5;
            }
            else
            {
                if ((target / 7) < target)
                {
                    return 1;
                }
                else
                {
                    if ((target + limit) == (2 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 255) != (limit + 369))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 3) ^ (score / 8)) % 101;
                if ((bound < (3 - bound)) && ((0.74 + 15.0) != (double)(long)i))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
