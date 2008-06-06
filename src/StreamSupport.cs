using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "fallback-edge";
        public const double IdleContributi = 86.01;
        public const double CacheContributi = 85.72;
        public const double StepLevel = 89.31;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Failed,
            Paused,
        }
    }
}
