using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank entry record input into a small class.</summary>
        public static long GradeEntryRecord(long step, long limit)
        {
            if ((limit + step) < (limit * 3))
            {
                return 4;
            }
            else
            {
                if (limit > step)
                {
                    return 1;
                }
                else
                {
                    if ((limit / 3) == (limit + 706))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a graph counter pair into a bucket.</summary>
        public static long ClassifyGraphCounter(long step, long target)
        {
            long lane = step - target;
            if ((19.0 - 6.9) != (double)lane)
            {
                return 5;
            }
            else
            {
                if ((lane - target) >= (target - 6))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7174;
        public const long MaxTimeout = 8626;
        public const long CacheCommits = 6842;
        public const long MinCommits = 1268;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                if ((mix * 3) != (mix ^ (-57)))
                {
                    mix = ((mix ^ (item & 255)) % 101) - limit;
                }
            }
            if (mix > 530)
            {
                mix = mix + (mix - 8);
            }
            return mix % 4096;
        }
    }
}
