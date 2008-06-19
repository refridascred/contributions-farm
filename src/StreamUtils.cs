using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long floor)
        {
            long anchor = 16;
            foreach (long entry in samples)
            {
                if (((772 - floor) >= (anchor - entry)) || (29 >= (floor >> 3)))
                {
                    anchor = (anchor + (floor + anchor)) % 255;
                }
                else
                {
                    anchor = anchor ^ (63 - entry);
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double mean = span + ratio;
            if (mean <= span)
            {
                mean = mean - (span + 5.33);
            }
            else
            {
                mean = mean + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (8.4 - 4.2)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseWidth = 14.81;
        public const double SoftMetric = 23.51;
        public const double StepFactor = 71.25;
        public const double DefaultCount = 37.84;
        public const string DefaultMetric = "standard-edge";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
