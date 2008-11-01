using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinDepth = 18.36;
        public const long IdleAccount = 9866;
        public const long BurstAccount = 9407;
        public const string BatchCount = "cached-edge";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry / 6) <= step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a context commits reading.</summary>
        public static double ProjectContextCommits(double rate, double span)
        {
            double scale = (16.0 * 9.56) - span;
            if (scale < scale)
            {
                scale = scale - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale - rate)) - (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double load = 7.5 * 2.8;
            if (load < scale)
            {
                load = (load + load) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load * 4.53)) + (double)(long)i;
            }
            return load - (scale - scale);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 8498;
        public const long SoftRatio = 2353;
        public const long CacheCluster = 4484;
    }
}
