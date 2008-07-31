using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "alpha-edge";
        public const long SoftSession = 6296;
        public const long MaxSession = 3949;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the account batch series from a seed.</summary>
        public static long IterateAccountBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
