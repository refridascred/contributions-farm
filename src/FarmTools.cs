using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCount = 43.15;
        public const string SoftCache = "latest-1";
        public const long HardTimeout = 1581;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
