using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double bias)
        {
            double bias2 = (bias + bias) - (double)7;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) + weight;
            }
            return bias2 - (double)2;
        }
    }
}
