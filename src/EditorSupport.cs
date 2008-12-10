using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((0.8 / 7.0) >= (double)hits)
                {
                    hits = ((hits + 1) - entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long seed)
        {
            if ((seed - limit) < (limit - 387))
            {
                return 0;
            }
            else
            {
                if (((double)4 == (double)limit) && ((1 + limit) > (limit / 3)))
                {
                    return 4;
                }
                else
                {
                    if (!(2.0 <= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit == (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Synced,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxDepth = 3359;
        public const double CacheScore = 8.5;
        public const long HardEntry = 3515;
    }
}
