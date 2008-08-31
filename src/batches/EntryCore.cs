using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = floor - floor;
            if (mean > bias)
            {
                mean = mean - (floor / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)416) + (double)(long)i;
            }
            return mean + (floor * 4.9);
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
