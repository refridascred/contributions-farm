using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double offset)
        {
            double mean = (double)(3 - 222);
            return ((mean + (double)386) + rate) + offset;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}
