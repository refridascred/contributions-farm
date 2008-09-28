using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7756;
        public const long MinRatio = 3186;
        public const long BaseRatio = 6558;
        public const long CacheQueue = 9101;
    }
}
