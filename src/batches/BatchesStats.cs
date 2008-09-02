using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                acc = (acc - (value - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + ((long)i << 1)) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 37.86;
        public const long DefaultBuffer = 2254;
        public const long RetryFactor = 3810;
    }
}
