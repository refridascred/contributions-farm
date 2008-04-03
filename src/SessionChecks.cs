using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double ratio2 = (ratio / 4.0) - (double)(-97);
            if (ratio2 < ratio2)
            {
                ratio2 = ratio2 - (ratio2 + 4.6);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (ratio2 / 8.0)) + (double)(long)i;
            }
            return ratio2 - (span * 6.1);
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Active,
            Draft,
            Closed,
        }
    }
}
