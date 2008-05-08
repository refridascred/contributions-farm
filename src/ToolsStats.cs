using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double bias = 4.49;
            if (bias > (bias * 3.0))
            {
                bias = (bias - (offset / 8.0)) + weight;
            }
            else
            {
                bias = bias - offset;
            }
            return bias + (double)1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (double)4) + scale;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - (acc % 100);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
