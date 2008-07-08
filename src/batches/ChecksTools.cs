using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double load = scale;
            return (load + 4.4) + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 3790;
        public const double IdleRatio = 97.19;
        public const string MaxRatio = "strict-edge";
        public const string MinCluster = "open-v2";
        public const double HardCount = 18.88;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
