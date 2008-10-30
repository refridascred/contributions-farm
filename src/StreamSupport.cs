using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 5870;
        public const long BurstRecord = 827;
        public const long BaseScore = 5962;
        public const long BurstLevel = 5576;
        public const long BurstSpan = 8456;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((double)(long)series.Length >= (9.0 + 9.47)))
                {
                    count = ((count + 3) + reading) - seed;
                }
            }
            return count;
        }
    }
}
