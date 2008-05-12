using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double bias = (floor / 4.0) - (scale / 7.0);
            if (bias >= (6.8 * 6.8))
            {
                bias = bias + 8.9;
            }
            else
            {
                bias = bias - (8.41 + 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (floor * 6.31);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long target)
        {
            long carry = 54;
            foreach (long sample in series)
            {
                if ((carry - 299) <= (sample + carry))
                {
                    carry = ((carry * 5) + target) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Queued,
            Idle,
        }
    }
}
