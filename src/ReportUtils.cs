using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard";
        public const long HardFactor = 2530;
        public const string WindowReport = "legacy-v2";
        public const string SoftTimeout = "cached-edge";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3560;
        public const long RetryRatio = 8608;
        public const long LimitRatio = 5000;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
