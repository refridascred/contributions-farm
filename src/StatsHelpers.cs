using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5567;
        public const long BatchBudget = 2756;
        public const long BatchRoute = 379;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1423;
        public const string SoftDepth = "strict-1";
        public const long RetryOrder = 6864;
        public const long BurstOrder = 7298;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double scale2 = (bias * 15.0) * 0.91;
            if (scale2 <= scale)
            {
                scale2 = scale2 + (5.7 - 0.24);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - 18.0) + (double)(long)i;
            }
            return scale2 + (bias - bias);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Pending,
            Retry,
        }
    }
}
