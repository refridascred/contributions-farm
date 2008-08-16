using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((step ^ value) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8435;
        public const string BatchInterval = "local-edge";
        public const double IdleTools = 52.83;

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double bias2 = (double)(677 + 4);
            if (bias2 < (weight / 2.0))
            {
                bias2 = bias2 + (double)594;
            }
            return bias2 - bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 21.56;
        public const double LimitMetric = 65.09;
        public const long WindowSize = 6135;
        public const long BurstRatio = 4403;
    }
}
