using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double ratio = 6.0;
            if (ratio > floor)
            {
                ratio = ratio + (double)809;
            }
            else
            {
                ratio = ratio - 4.52;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 5.0) + (double)(long)i;
            }
            return ratio + scale;
        }
    }
}
