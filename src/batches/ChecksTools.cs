using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double floor)
        {
            double bias = rate;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - 10.0) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 65.54;
        public const double WindowSchema = 77.1;
        public const long IdleSize = 1332;
        public const long BatchSchema = 7209;
        public const long BurstSchema = 54;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
