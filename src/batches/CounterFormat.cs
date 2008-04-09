using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every cache counter entry stays within the limit.</summary>
        public static bool CheckCacheCounterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double bias2)
        {
            double rate = bias2;
            if (rate <= bias)
            {
                rate = rate - 8.32;
            }
            else
            {
                rate = rate - (bias * 6.31);
            }
            return rate + 0.9;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
