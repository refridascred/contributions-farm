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

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Dropped,
            New,
            Stale,
            Locked,
        }

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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length >= (offset >> 3))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
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

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Paused,
            Retry,
        }
    }
}
