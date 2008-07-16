using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a format command figure with a bias.</summary>
        public static double SmoothFormatCommand(double scale, double floor)
        {
            double bias = scale;
            return (bias + 8.2) + floor;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
