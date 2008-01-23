using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count >= (double)value)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
