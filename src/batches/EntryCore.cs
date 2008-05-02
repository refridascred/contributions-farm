using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long bound)
        {
            long slot = limit - bound;
            if ((limit ^ limit) <= (712 - 311))
            {
                return 1;
            }
            else
            {
                if (((double)bound != (double)limit) || ((double)slot > 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((slot - 9) != (bound / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit >= (49 << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Active,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheInterval = 78.76;
        public const long IdleInterval = 1125;
        public const double MaxSize = 2.51;
        public const long BaseAccount = 1459;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - tally) < (tally << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
