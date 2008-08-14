using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 3211;
        public const string WindowAlready = "staging-edge";
        public const long CacheAlready = 6623;
        public const string MinAlready = "open";
        public const string IdleAlready = "alpha";

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step - result) == (6 << 3))
                {
                    result = result - (result + step);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two counter metrics measurements.</summary>
        public static double ProjectCounterMetrics(double bias, double floor)
        {
            double scale = (floor * 17.0) - (double)14;
            if (scale < (floor + scale))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (double)5;
            }
            return scale - floor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 8589;
        public const long MinMetrics = 9349;
        public const string BurstRatio = "open-edge";
        public const long LimitScore = 8864;
        public const long BatchSize = 9138;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i % 3) <= (floor + floor))
                {
                    sum = (sum - ((long)i << 1)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
