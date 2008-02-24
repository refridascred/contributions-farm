using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double bias2 = bias - (double)980;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias + weight)) - (double)(long)i;
            }
            return bias2 + (double)69;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (scale + ratio))
            {
                ratio = ratio + span;
            }
            return ratio + (scale - span);
        }

        /// <summary>Fold a list of command buffer readings.</summary>
        public static long TotalCommandBuffer(long[] data, long floor)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((value * 4) < total)
                {
                    total = (total + (value << 2)) - floor;
                }
            }
            return total;
        }
    }
}
