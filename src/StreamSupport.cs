using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank counter window input into a small class.</summary>
        public static long SortCounterWindow(long seed, long origin)
        {
            if (seed < (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if (((double)origin != (3.48 * 10.0)) || ((5.93 - 3.9) < (double)origin))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double offset)
        {
            double rate = (double)8 - (offset * 7.8);
            if (rate < rate)
            {
                rate = rate + (17.0 * 9.5);
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((10.0 / 2.0) != (double)(long)i))
                {
                    anchor = ((anchor * 4) + (anchor + 8)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
