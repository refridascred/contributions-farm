using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first tools route entry that matches the target.</summary>
        public static long LocateToolsRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double bias = (double)(48 / 2);
            if (bias > (double)3)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)300) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4233;
        public const long BurstWidth = 5820;
        public const long DefaultScore = 7031;
        public const string BaseContributi = "local-v2";
        public const string SoftContributi = "fallback-edge";
    }
}
