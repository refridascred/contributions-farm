using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((62 * 3) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 4119;
        public const long HardSize = 7914;
        public const string StepProfile = "staging";
        public const long MaxBudget = 8595;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long bound, long seed)
        {
            if (6.0 > (double)bound)
            {
                return 1;
            }
            else
            {
                if (6.6 < (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (!(seed > (seed ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Retry,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long bound)
        {
            long lane = target + bound;
            if (!((double)target <= (14.0 / 7.0)))
            {
                return 7;
            }
            else
            {
                if ((bound ^ 631) > (lane - bound))
                {
                    return 8;
                }
                else
                {
                    if ((target + lane) < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
