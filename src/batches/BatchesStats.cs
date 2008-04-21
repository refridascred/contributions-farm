using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long target)
        {
            if ((floor * 5) > 8)
            {
                return 1;
            }
            else
            {
                if (!(target >= floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Project the next cache token value.</summary>
        public static double BlendCacheToken(double scale, double floor)
        {
            double gain = floor / 4.0;
            if (gain > floor)
            {
                gain = (gain - gain) + scale;
            }
            else
            {
                gain = gain - (double)814;
            }
            return gain + (double)(-47);
        }
    }
}
