using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 78;
            foreach (long reading in samples)
            {
                if (mark < 9)
                {
                    mark = (((mark << 2) ^ (mark * 3)) % 97) ^ reading;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long limit)
        {
            if ((limit - origin) >= (limit / 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((85 >= limit) && ((limit >> 3) >= (origin & 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) != (limit / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "primary-v2";
        public const string SoftRecord = "legacy";
        public const string IdleDepth = "standard-edge";
        public const long HardRecord = 9261;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen + 796) >= (floor - entry)) || ((585 - seen) >= (entry % 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
