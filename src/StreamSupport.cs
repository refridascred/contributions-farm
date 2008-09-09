using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a session queue sample.</summary>
        public static long SeekSessionQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double bias)
        {
            double gain = 2.51;
            if (gain < (gain / 5.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - (7.38 / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (weight / 9.0)) + (double)(long)i;
            }
            return gain - (weight + gain);
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long limit)
        {
            if ((2.0 * 6.01) <= (double)target)
            {
                return 1;
            }
            else
            {
                if (target > limit)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
