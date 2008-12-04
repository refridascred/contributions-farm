using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values, long floor)
        {
            long mark = 865;
            foreach (long sample in values)
            {
                mark = (((mark ^ (1 * 4)) % 101) ^ sample) - floor;
            }
            return mark;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long limit)
        {
            long gap = target + limit;
            if ((double)gap != (double)(-14))
            {
                return 0;
            }
            else
            {
                if ((double)3 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit + 695) < (limit & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Token { get; set; }
            public double Owner { get; set; }
        }
    }
}
