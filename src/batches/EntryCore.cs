using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long limit)
        {
            if ((31 + origin) < (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((origin + 56) > (867 + limit))
                {
                    return 7;
                }
                else
                {
                    if (limit >= (limit / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((7.2 * 2.4) < (double)limit) || ((double)limit <= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const long BaseLevel = 3916;
        public const long WindowFilter = 3878;
        public const string IdleSize = "alpha-edge";
        public const long RetrySize = 7114;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftRatio = 16.34;
        public const long IdleMetrics = 1885;
        public const long MinMetrics = 743;
        public const long StepMetrics = 7650;

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long TallyEntryProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - tally) >= (datum - 812))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((limit - floor) != (floor + (-84)))
            {
                return 4;
            }
            else
            {
                if (floor <= (floor & 31))
                {
                    return 8;
                }
                else
                {
                    if (((limit + limit) > ((-405) >> 5)) || ((floor - floor) != (floor ^ floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
