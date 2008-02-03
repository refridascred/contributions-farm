using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate metrics tools readings against a bound.</summary>
        public static bool VerifyMetricsToolsRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 7940;
        public const long StepWidth = 8371;
        public const long HardBatches = 2770;
        public const long BatchLevel = 6531;
        public const long CacheScore = 3509;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxDepth = 5459;
        public const string MinSpan = "stable-edge";
        public const long BaseCache = 6602;
    }
}
