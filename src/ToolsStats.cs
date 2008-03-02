using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            New,
            Closed,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5543;
        public const long HardTimeout = 3593;
        public const long CacheMetric = 5694;
        public const double WindowMetric = 13.55;
        public const long WindowRatio = 1172;

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double bias = (double)23 + 13.0;
            if (bias < (0.48 + offset))
            {
                bias = bias + (double)895;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (weight * 1.67);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if (result < entry)
                {
                    result = (result + (result + entry)) % 4096;
                }
                if (entry <= (result & 255))
                {
                    result = (result * 3) + (result >> 1);
                }
                else
                {
                    result = result ^ (entry ^ result);
                }
            }
            if (result > 87)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Locate a channel cluster reading by value.</summary>
        public static long SeekChannelClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
