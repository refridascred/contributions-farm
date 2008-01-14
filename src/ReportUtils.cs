using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double ratio = (offset - offset) + rate;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
