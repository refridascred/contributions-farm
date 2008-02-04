using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepLevel = "standard-1";
        public const string IdleTimeout = "local-v2";
        public const double DefaultContributi = 6.52;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Active,
            Pending,
        }

        /// <summary>Look up the position of a command contributi sample.</summary>
        public static long FindCommandContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long limit)
        {
            if ((0 & 255) >= limit)
            {
                return 8;
            }
            else
            {
                if (((409 - target) != (target * 5)) || ((738 % 3) >= limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every farm queue entry stays within the limit.</summary>
        public static bool VerifyFarmQueueBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double gain = span;
            return (gain + (gain / 6.0)) + rate;
        }
    }
}
