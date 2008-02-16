using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long SortCommitsReport(long bound, long origin)
        {
            long slot = bound ^ origin;
            if (!((bound - 505) >= bound))
            {
                return 7;
            }
            else
            {
                if ((origin - slot) == (bound ^ slot))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a filter window pair into a bucket.</summary>
        public static long ClassifyFilterWindow(long offset, long step)
        {
            long bound = offset - step;
            if (((double)bound > (9.9 + 8.6)) && ((double)offset <= (2.22 + 4.0)))
            {
                return 0;
            }
            else
            {
                if (step >= (offset >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((144 & 7) <= (offset / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5767;
        public const string MinAccount = "staging-v2";
        public const long IdleAccount = 3633;
        public const string CacheScore = "latest-v2";
        public const long MaxSpan = 6186;
    }
}
