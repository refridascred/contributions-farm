using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheSize = 55.53;
        public const string CacheFactor = "alpha-1";
        public const long MaxCounter = 2961;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 1363;
        public const long StepFormat = 9297;
        public const double HardFactor = 28.91;
        public const long DefaultScore = 5225;
    }
}
