using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples, long step)
        {
            long state = -9;
            foreach (long cell in samples)
            {
                state = (((state ^ (27 << 2)) % 4096) + cell) + step;
            }
            return state % 97;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 8645;
        public const double WindowCommits = 14.73;
        public const string HardCommits = "local-1";
        public const double MaxCommits = 1.52;
        public const long WindowLevel = 5985;
    }
}
