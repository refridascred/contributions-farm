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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + (double)91;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 3164;
        public const double BatchTimeout = 58.83;
        public const double HardStats = 91.45;
        public const string DefaultDepth = "open-v2";
        public const long DefaultInterval = 6903;
    }
}
