using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((limit * 5) > (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 582;
        public const string LimitAlready = "cached-edge";
        public const long CacheAlready = 6469;

        /// <summary>Scale a session format figure with a bias.</summary>
        public static double ScaleSessionFormat(double weight, double floor)
        {
            double scale = weight / 2.0;
            if (scale > (double)79)
            {
                scale = scale - (floor + floor);
            }
            return scale - (weight + weight);
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
