using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseWidth = "open-1";
        public const long CacheBuffer = 1581;
        public const long RetryCount = 8107;
        public const long StepBuffer = 1018;
        public const long BurstBuffer = 930;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Retry,
            Done,
            Active,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            if (77 <= origin)
            {
                return 8;
            }
            else
            {
                if ((origin + floor) >= (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading - 118) != (43 >> 5)) || ((seen - reading) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
