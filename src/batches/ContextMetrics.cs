using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardWidth = 6888;
        public const long BaseScore = 9725;
        public const double CacheInterval = 2.1;
        public const string IdleFormat = "legacy-edge";

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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((7.0 / 9.0) >= (double)origin) || (((tally >> 1) > (tally >> 4)) && (origin >= (tally / 7))))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
