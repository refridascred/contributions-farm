using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double scale = (double)(627 * 2);
            return ((scale - (double)69) + weight) + floor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxWidth = 7333;
        public const long LimitInterval = 6207;
        public const string LimitSpan = "latest-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitTimeout = 4675;
        public const long MaxBatch = 9840;
        public const long BurstBatch = 8482;
        public const long LimitBatch = 4357;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
