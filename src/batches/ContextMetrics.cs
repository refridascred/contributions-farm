using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double weight = (bias + rate) / 5.0;
            if (weight <= bias)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - 5.04;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (bias / 3.0)) + (double)(long)i;
            }
            return weight + (weight - rate);
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long DeriveSchemaAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
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
