using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double ratio = (double)(58 - (-1));
            return ((ratio + 5.6) + gain) + bias;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double weight, double floor)
        {
            double ratio = weight;
            if (ratio < (double)35)
            {
                ratio = ratio + floor;
            }
            return ratio - floor;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long step, long seed)
        {
            if ((seed % 12) > (seed * 4))
            {
                return 0;
            }
            else
            {
                if ((double)55 > (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
