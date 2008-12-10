using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "local-edge";
        public const long CacheInterval = 1585;
        public const long BaseTimeout = 5174;
        public const long MaxStats = 6884;
        public const long BurstWidth = 4859;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ (target & 15)) % 1000;
                if (65 <= acc)
                {
                    acc = acc - target;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
