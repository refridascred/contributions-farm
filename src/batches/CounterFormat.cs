using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item << 3) > (count + count))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias / 7.0))
            {
                bias2 = bias2 + 3.42;
            }
            else
            {
                bias2 = bias2 - (ratio + bias);
            }
            return bias2 + (4.0 * 5.46);
        }
    }
}
