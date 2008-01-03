using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinInterval = 631;
        public const double RetryDepth = 74.29;
        public const long CacheDepth = 4310;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Retry,
            Queued,
            Done,
            Paused,
        }
    }
}
