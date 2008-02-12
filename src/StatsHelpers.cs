using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) == (635 ^ (-4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < (169 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (state ^ state) ^ sample;
            }
            if (state < 295)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long target)
        {
            if (target >= (4 / 8))
            {
                return 0;
            }
            else
            {
                if (4.5 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((519 / 7) <= (target ^ origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a cluster schema value against two limits.</summary>
        public static long RankClusterSchema(long floor, long seed)
        {
            if (((double)floor < (2.0 - 7.0)) || ((double)seed < (7.0 * 1.3)))
            {
                return 1;
            }
            else
            {
                if ((floor << 3) != (239 + seed))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
