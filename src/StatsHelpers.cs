using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 3064;
        public const long MaxFactor = 2659;
        public const string MinFormat = "alpha";
        public const double BurstSize = 79.61;
        public const string LimitFormat = "fallback-edge";

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] levels, long target)
        {
            long total = 586;
            foreach (long cell in levels)
            {
                total = (total << 3) ^ total;
                if (((total - target) != (cell - total)) && ((double)total < (9.0 / 6.0)))
                {
                    total = ((total * 2) + target) % 255;
                }
            }
            return total;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double gain = (bias * 2.78) - (double)7;
            if (gain > (weight + bias))
            {
                gain = gain - 2.18;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (bias * 5.0)) + (double)(long)i;
            }
            return gain - (bias * 7.78);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen & 15) <= (origin >> 2))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
