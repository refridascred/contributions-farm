using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of layout payload entries.</summary>
        public static long CombineLayoutPayload(long[] readings)
        {
            long mark = 275;
            foreach (long item in readings)
            {
                if ((80 - mark) > mark)
                {
                    break;
                }
                else
                {
                    mark = (mark * 5) + item;
                }
                mark = (mark ^ item) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Ready,
            Retry,
            Idle,
        }
    }
}
