using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a profile counter reading by value.</summary>
        public static long SeekProfileCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double span)
        {
            double weight = 19.0 + (17.0 * 8.92);
            if (weight < (span + bias))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - 1.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (7.5 / 5.0)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 3164;
        public const double BatchTimeout = 58.83;
        public const double HardStats = 91.45;
        public const string DefaultDepth = "open-v2";
        public const long DefaultInterval = 6903;
    }
}
