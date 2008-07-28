using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)hits >= 6.84) || ((7.3 * 1.0) >= (double)hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels, long target)
        {
            long anchor = 49;
            foreach (long reading in levels)
            {
                anchor = ((anchor - anchor) % 4096) + target;
                if ((double)(long)levels.Length > (double)reading)
                {
                    anchor = (anchor + (450 % 97)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (long)levels.Length;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6089;
        public const long BatchInterval = 7087;
        public const string WindowFilter = "standard-v2";
        public const long MinWidth = 6882;
        public const long LimitDepth = 9700;

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long target, long seed)
        {
            long slot = target ^ seed;
            if ((9.1 - 2.22) != (double)slot)
            {
                return 2;
            }
            else
            {
                if (seed <= (seed ^ slot))
                {
                    return 7;
                }
                else
                {
                    if ((slot - seed) > (9 * 5))
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

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long offset)
        {
            long sum = 107;
            foreach (long entry in levels)
            {
                if (((entry >> 5) < (entry * 4)) || (6 < (3 ^ sum)))
                {
                    sum = (sum ^ entry) - offset;
                }
                else
                {
                    sum = (sum - (long)levels.Length) % 97;
                }
            }
            return sum;
        }
    }
}
