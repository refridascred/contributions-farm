using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the metrics command series from a seed.</summary>
        public static long SeriesMetricsCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = sum - (offset - offset);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double mean = (bias * 7.73) - bias;
            if (mean > (floor - 4.5))
            {
                mean = mean - (double)3;
            }
            return mean - 2.88;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long step)
        {
            long acc = 947;
            foreach (long value in values)
            {
                acc = ((acc * 5) + acc) ^ value;
                if (step >= (step * 5))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Retry,
            Dropped,
            Locked,
        }
    }
}
