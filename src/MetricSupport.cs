using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstDepth = 2861;
        public const string StepFactor = "fallback";
        public const long BatchCount = 8244;
        public const long BurstBatch = 1497;
        public const long WindowInterval = 9943;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data, long origin)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = ((result ^ value) % 4096) - origin;
            }
            return result;
        }
    }
}
