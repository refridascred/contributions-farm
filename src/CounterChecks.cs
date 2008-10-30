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

        /// <summary>Adjust a commits metric reading.</summary>
        public static double ProjectCommitsMetric(double bias, double offset)
        {
            double gain = offset;
            if (gain >= (bias / 5.0))
            {
                gain = gain - (offset + offset);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (offset + gain)) + (double)(long)i;
            }
            return gain + offset;
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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
