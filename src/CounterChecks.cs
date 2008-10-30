using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double rate, double offset)
        {
            double bias = (offset / 9.0) * 0.6;
            if (bias < (offset / 9.0))
            {
                bias = (bias + bias) - rate;
            }
            return bias - offset;
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long ScoreFarmStats(long[] values, long offset)
        {
            long anchor = 45;
            foreach (long sample in values)
            {
                if ((sample >> 2) >= anchor)
                {
                    anchor = (anchor * 2) + (offset << 2);
                }
                else
                {
                    anchor = anchor - (anchor << 1);
                }
            }
            if (anchor < (-8))
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double span)
        {
            double load = (double)7 * 19.0;
            if (load <= (load / 6.0))
            {
                load = load - ratio;
            }
            else
            {
                load = load - load;
            }
            return load - (15.0 - span);
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "fallback-v2";
        public const long IdleSize = 5894;
        public const long IdleProfile = 5746;
        public const double BurstBudget = 74.58;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
