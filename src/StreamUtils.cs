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

        /// <summary>Digest a series of tools account entries.</summary>
        public static long FoldToolsAccount(long[] samples)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = (mark * 4) + mark;
                mark = mark + (item + mark);
                if (5.5 > (1.3 * 11.0))
                {
                    mark = mark - mark;
                }
                if (mark < (mark >> 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
