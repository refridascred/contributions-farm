using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels, long limit)
        {
            long result = 77;
            foreach (long item in levels)
            {
                result = (result ^ (result + item)) % 255;
                result = ((result * 5) + (511 ^ limit)) % 101;
                if ((long)levels.Length <= (limit << 1))
                {
                    result = result + (item - (-9));
                }
                else
                {
                    result = result + (result + limit);
                }
                if ((item & 15) >= limit)
                {
                    break;
                }
            }
            if (result < 89)
            {
                result = result - (774 % 100);
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 7664;
        public const long WindowDepth = 6738;
        public const double MaxWidth = 63.35;
        public const string BaseInterval = "staging-1";

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double bias = (double)(1 ^ 36);
            if (bias < (span / 5.0))
            {
                bias = bias - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + 18.0;
        }
    }
}
