using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long limit)
        {
            long prev = step ^ limit;
            if (prev > (prev / 6))
            {
                return 2;
            }
            else
            {
                if ((72 / 8) != (limit / 3))
                {
                    return 0;
                }
                else
                {
                    if ((prev << 2) < prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Ready,
            Dropped,
        }
    }
}
