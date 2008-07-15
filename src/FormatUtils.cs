using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a window commits pair into a bucket.</summary>
        public static long ClassifyWindowCommits(long step, long target)
        {
            long offset = step + target;
            if ((offset + target) <= (step ^ target))
            {
                return 0;
            }
            else
            {
                if (((target / 3) < 37) && ((927 << 2) > (target - 8)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long bound, long bound2)
        {
            if ((double)bound2 == (8.0 - 6.0))
            {
                return 8;
            }
            else
            {
                if ((bound2 ^ bound2) > (bound2 / 9))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels, long seed)
        {
            long mark = -16;
            foreach (long item in levels)
            {
                mark = ((mark ^ (3 / 2)) ^ item) + seed;
            }
            return mark;
        }

        /// <summary>Classify a already account pair into a bucket.</summary>
        public static long RankAlreadyAccount(long target, long target2)
        {
            long bound = target ^ target2;
            if ((double)target == (5.9 * 6.0))
            {
                return 5;
            }
            else
            {
                if ((847 * 5) <= (bound << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Idle,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Done,
            New,
        }
    }
}
