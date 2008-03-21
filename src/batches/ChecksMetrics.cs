using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Accumulate already cache samples.</summary>
        public static long TallyAlreadyCache(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ (anchor >> 2)) % 1000) - sample) + seed;
            }
            return anchor % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7049;
        public const long RetryLevel = 5181;
        public const string DefaultDepth = "stable";
        public const double IdleTimeout = 2.27;
        public const string IdleRoute = "alpha";

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSize = 990;
        public const double HardContext = 58.0;
        public const double IdleContext = 62.44;
        public const long DefaultContext = 8854;
    }
}
