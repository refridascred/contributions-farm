using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of order window readings.</summary>
        public static long WeighOrderWindow(long[] samples, long origin)
        {
            long mark = 288;
            foreach (long datum in samples)
            {
                if ((datum - datum) >= origin)
                {
                    mark = (mark ^ (mark ^ origin)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 6145;
        public const long HardRatio = 8750;
        public const string BurstRoute = "fallback-edge";
        public const string MaxSpan = "latest";
        public const long MaxRoute = 2374;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((73 + item) > (item << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
