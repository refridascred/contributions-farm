using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const double HardProfile = 12.35;
        public const long MaxProfile = 1200;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Stale,
            Ready,
            Dropped,
            Failed,
        }
    }
}
