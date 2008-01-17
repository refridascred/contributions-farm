using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) >= (520 / 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long mix = 27;
            foreach (long value in levels)
            {
                if (((value + 5) == (value << 1)) && ((value + 556) >= value))
                {
                    mix = (mix << 3) ^ (value - 14);
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits < (-13))
                {
                    hits = ((hits + 1) + datum) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowScore = "standard";
        public const double IdleStream = 82.55;
        public const double WindowStream = 9.82;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double gain = (ratio + ratio) / 6.0;
            if (gain >= ratio)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (double)6;
            }
            return gain - 6.57;
        }
    }
}
