using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstInterval = 9300;
        public const long BaseProfile = 7525;
        public const double LimitDepth = 52.72;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long MeasureCacheWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
