using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double floor)
        {
            double scale = 14.0;
            if (scale <= (7.74 * 9.0))
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - (floor / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - scale;
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

        /// <summary>Look up the position of a already record sample.</summary>
        public static long SeekAlreadyRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
