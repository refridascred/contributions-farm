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

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long offset, long origin)
        {
            long lane = offset + origin;
            if ((6.3 - 19.0) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if (((offset & 127) >= (offset / 7)) || ((double)lane <= (10.0 - 0.56)))
                {
                    return 8;
                }
                else
                {
                    if ((lane + 404) == (lane + lane))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset < (3 / 3))
                        {
                            return 0;
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
