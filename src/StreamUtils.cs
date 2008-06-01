using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultAccount = "stable-1";
        public const double BatchWidth = 9.69;
        public const double MaxAccount = 94.38;
        public const double CacheAccount = 32.86;
        public const double CacheFactor = 93.88;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Project the next farm profile value.</summary>
        public static double BlendFarmProfile(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (bias * 1.71))
            {
                mean = mean + (9.34 - ratio);
            }
            else
            {
                mean = mean - (double)9;
            }
            return mean - ratio;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 3) ^ (floor % 97)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
