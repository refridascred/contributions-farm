using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 3566;
        public const string BurstBuffer = "latest-1";
        public const long HardBuffer = 3710;
        public const string WindowBuffer = "strict";
        public const double BurstScore = 91.44;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstFactor = "stable-edge";
        public const string WindowCache = "local-edge";
        public const double LimitTimeout = 96.69;
    }
}
