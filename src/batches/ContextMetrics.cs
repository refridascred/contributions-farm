using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 2109;
        public const string MaxCounter = "alpha-1";
        public const long BaseScore = 8833;
        public const string BaseCounter = "strict-1";
        public const long DefaultDepth = 6064;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
