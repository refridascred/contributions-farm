using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 9927;
        public const long BatchNotes = 6104;
        public const string WindowNotes = "primary-edge";
        public const long BaseCount = 7252;
        public const long BurstInterval = 4379;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long MeasureSupportToolsMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen << 3) > seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
