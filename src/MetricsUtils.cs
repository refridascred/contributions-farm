using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
