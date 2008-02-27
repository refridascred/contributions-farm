using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading >= 19.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((double)matches >= (double)(long)samples.Length) && ((double)5 < (double)matches))
                {
                    matches = ((matches + 3) ^ cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7683;
        public const long DefaultSize = 3916;
        public const string IdleDepth = "primary-edge";
        public const long CacheSpan = 1259;
        public const long CacheCommits = 4444;
    }
}
