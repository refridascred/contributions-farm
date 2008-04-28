using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 1.22;
        public const long RetryChecks = 6159;
        public const long DefaultChecks = 3869;
        public const long SoftRatio = 3113;
        public const long MinChecks = 231;

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long offset)
        {
            if ((seed - offset) < (5 ^ seed))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((offset * 4) != (offset % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long MeasureFilterTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((4.4 * 5.97) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long target2)
        {
            if ((6 + 52) != (target + target2))
            {
                return 4;
            }
            else
            {
                if ((target2 - target) >= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (double)count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
