using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((27 / 9) == (entry % 10))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LocateCacheClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = -398;
            foreach (long reading in samples)
            {
                acc = (((acc << 3) ^ (401 - 405)) % 255) ^ reading;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((floor <= sample) && (((long)readings.Length ^ 271) >= floor))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
