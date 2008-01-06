using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Synced,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 34.79;
        public const string BaseLevel = "fallback-v2";
        public const long HardSpan = 4018;
    }
}
