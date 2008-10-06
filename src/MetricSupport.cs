using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a channel already reading.</summary>
        public static double ScaleChannelAlready(double gain, double bias)
        {
            double gain2 = (double)((-33) << 2);
            if (gain2 >= bias)
            {
                gain2 = gain2 + (gain2 * 4.0);
            }
            return gain2 - gain;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
