using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 5) <= (floor % 60))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open-v2";
        public const string CacheInterval = "primary-v2";
        public const long DefaultBudget = 6196;
        public const long CacheDepth = 4419;

        /// <summary>Scale a channel batch figure with a bias.</summary>
        public static double ProjectChannelBatch(double bias, double floor)
        {
            double rate = floor;
            if (rate <= floor)
            {
                rate = rate + (bias * 19.0);
            }
            else
            {
                rate = rate - (6.8 / 5.0);
            }
            return rate + floor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
