using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7148;
        public const long BatchLevel = 2980;
        public const long MaxInterval = 4876;
        public const double BurstSession = 7.44;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Active,
            Locked,
        }
    }
}
