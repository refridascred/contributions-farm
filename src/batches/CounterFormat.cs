using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double bias)
        {
            double ratio2 = (double)73;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + bias) - (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Derive the next layout counter value from a seed.</summary>
        public static long RollLayoutCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (((step << 1) > (anchor & 1)) && (((long)i - step) >= 9))
                {
                    anchor = (anchor ^ (anchor >> 4)) % 65521;
                }
                else
                {
                    anchor = anchor + 2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
