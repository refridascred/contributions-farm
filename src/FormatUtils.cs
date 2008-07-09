using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double rate2 = (double)(9 << 2);
            if (rate2 > 6.03)
            {
                rate2 = (rate2 + rate2) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate * 9.2);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= 6.37)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 4102;
        public const string HardCluster = "cached-v2";
        public const long DefaultCluster = 2243;
        public const long DefaultFactor = 6926;

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5860;
        public const string WindowRatio = "standard-1";
        public const long LimitSize = 1572;
        public const long SoftInterval = 5966;
        public const string RetryStream = "latest-edge";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double bias = 2.88;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias + (bias + bias)) + (double)(long)i) - scale) + offset;
            }
            return bias + (double)91;
        }
    }
}
