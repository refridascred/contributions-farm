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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
