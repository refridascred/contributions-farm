using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8609;
        public const long LimitProfile = 8860;
        public const long RetryProfile = 3368;
        public const long MaxProfile = 730;

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double offset)
        {
            double scale = gain + (gain / 3.0);
            if (scale <= (gain + scale))
            {
                scale = scale + (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 6309;
        public const double CacheOrder = 8.51;
        public const long WindowSize = 6421;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double weight, double floor)
        {
            double bias = (double)((-91) - 50);
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)(long)i) + weight;
            }
            return bias + floor;
        }
    }
}
