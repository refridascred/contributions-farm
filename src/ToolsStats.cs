using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if ((3.0 * 2.23) == (double)total)
                {
                    total = ((total << 3) ^ (275 * 4)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (430 & 31)) % 97;
                    total = total + (total + total);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double ratio, double bias)
        {
            double bias2 = 19.0;
            return ((bias2 + bias2) + ratio) + bias;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardCount = "primary-v2";
        public const long BatchWidth = 7680;
        public const long LimitRatio = 4963;
        public const long MaxFactor = 9616;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double bias = 8.05 / 3.0;
            if (bias >= 1.71)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (7.16 * 0.55);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
