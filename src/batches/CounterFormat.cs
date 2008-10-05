using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinScore = 83.31;
        public const long CacheCommand = 1179;
        public const long MinCommand = 919;
        public const long StepRatio = 9914;
        public const long IdleTimeout = 6388;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - matches) > (item % 97))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
