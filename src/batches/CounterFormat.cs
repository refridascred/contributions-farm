using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double rate = (double)(-672) - (bias * 6.45);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (7.42 + rate);
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 505;
        public const string HardCounter = "fallback-1";
        public const long SoftCounter = 4711;
        public const long DefaultCounter = 9834;
    }
}
