using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Stale,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepScore = "cached-edge";
        public const long SoftEntry = 6240;
        public const string BaseEntry = "local-v2";
        public const double IdleFactor = 77.56;

        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long SeriesClusterProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc - target)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 3) ^ (13 + (long)i2)) % 97;
                }
                acc = (acc + ((long)i + 31)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
