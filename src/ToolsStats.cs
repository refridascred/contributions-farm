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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((696 % 12) < (count >> 5)))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
