using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "primary";
        public const double IdleSpan = 46.71;
        public const long BurstTimeout = 1976;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSize = 990;
        public const double HardContext = 58.0;
        public const double IdleContext = 62.44;
        public const long DefaultContext = 8854;
    }
}
