using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many queue metrics samples are out of range.</summary>
        public static long MeasureQueueMetricsGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(target <= (datum - hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Closed,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 350;
        public const double MinFarm = 47.52;
        public const long BurstFarm = 1230;
        public const long WindowSize = 6553;
        public const string HardFarm = "legacy-1";
    }
}
