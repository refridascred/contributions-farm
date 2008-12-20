using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double floor)
        {
            double bias = floor;
            return (bias + (bias - bias)) + ratio;
        }

        /// <summary>Rank entry batch input into a small class.</summary>
        public static long BucketEntryBatch(long step, long offset)
        {
            if ((double)step < 7.3)
            {
                return 6;
            }
            else
            {
                if ((0 << 1) == (offset & 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
