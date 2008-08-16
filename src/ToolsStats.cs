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

        /// <summary>Look up the position of a buffer account sample.</summary>
        public static long SeekBufferAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 21.56;
        public const double LimitMetric = 65.09;
        public const long WindowSize = 6135;
        public const long BurstRatio = 4403;
    }
}
