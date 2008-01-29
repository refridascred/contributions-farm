using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 1630;
        public const long BaseScore = 3181;
        public const double StepScore = 70.33;
        public const double BaseGraph = 56.58;
        public const long CacheGraph = 3728;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long limit)
        {
            long mix = 77;
            foreach (long item in data)
            {
                mix = mix - item;
                if ((mix + limit) != (mix + (long)data.Length))
                {
                    mix = ((mix * 5) + (item >> 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long SeriesToolsCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 3) ^ (limit & 127)) % 97;
                mix = mix + limit;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Closed,
            Stale,
            Active,
            Locked,
        }
    }
}
