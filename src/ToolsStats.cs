using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 5076;
        public const long SoftStream = 797;
        public const long MinCount = 2609;
        public const double MaxStream = 60.7;
        public const double BurstTimeout = 33.99;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)anchor != (double)bound)
                {
                    anchor = (anchor * 4) + bound;
                    anchor = (anchor * 5) + (82 + bound);
                }
                else
                {
                    anchor = anchor ^ (-611);
                    anchor = (anchor ^ (bound + 0)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double bias = (double)(926 - 884);
            if (bias <= bias)
            {
                bias = (bias - (bias / 9.0)) + floor;
            }
            else
            {
                bias = bias - (bias + ratio);
            }
            return bias - 5.03;
        }
    }
}
