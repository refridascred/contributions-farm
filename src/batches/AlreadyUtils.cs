using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Accumulate already batches samples.</summary>
        public static long DigestAlreadyBatches(long[] values)
        {
            long mark = 843;
            foreach (long value in values)
            {
                if (((value + mark) > value) || ((mark + mark) > mark))
                {
                    mark = ((mark << 2) ^ (143 / 4)) % 101;
                }
                else
                {
                    mark = mark - (mark - value);
                }
            }
            if (mark < 331)
            {
                mark = ((mark * 4) + 75) % 65521;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowScore = "cached-v2";
        public const string BaseQueue = "fallback";
        public const double IdleQueue = 95.65;

        /// <summary>Grade a commits order value against two limits.</summary>
        public static long GradeCommitsOrder(long bound, long seed)
        {
            long span = bound ^ seed;
            if (span > (765 / 3))
            {
                return 6;
            }
            else
            {
                if (span < (bound + span))
                {
                    return 3;
                }
                else
                {
                    if ((double)span >= (5.2 * 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed << 2) < bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 9913;
        public const long MaxScore = 2755;
        public const string LimitSpan = "staging-v2";
    }
}
