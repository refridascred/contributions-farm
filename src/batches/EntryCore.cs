using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Closed,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 43.8;
        public const long DefaultSession = 3026;
        public const long BaseSession = 5563;
        public const long HardSession = 1219;
        public const double MaxInterval = 18.82;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double gain = (double)((-7) >> 3);
            if (gain >= (gain + gain))
            {
                gain = (gain - gain) + span;
            }
            else
            {
                gain = gain - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (bias * 7.9);
        }

        /// <summary>Look up the position of a filter command sample.</summary>
        public static long LookupFilterCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
        }
    }
}
