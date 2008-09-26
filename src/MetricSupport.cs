using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 1699;
        public const long StepBatch = 9462;
        public const long BatchSpan = 1155;
    }
}
