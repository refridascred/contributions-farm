using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long origin)
        {
            long bound = floor ^ origin;
            if ((2 + floor) <= (bound / 7))
            {
                return 7;
            }
            else
            {
                if ((bound & 127) > (floor - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (origin - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "stable-edge";
        public const string MinInterval = "staging-1";
        public const double BatchLevel = 96.2;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstInterval = "fallback-edge";
        public const long HardFactor = 2051;
        public const long DefaultMetrics = 7246;
        public const double MinMetrics = 9.26;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Done,
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long target)
        {
            if ((target & 3) != (target + target))
            {
                return 2;
            }
            else
            {
                if (offset <= (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if (((-80) * 2) != (97 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset + target) >= offset) && ((85 >> 1) > (offset + offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
