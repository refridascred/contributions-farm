using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long offset)
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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = (double)(75 - 57);
            if (scale2 < bias)
            {
                scale2 = scale2 + (scale - scale);
            }
            else
            {
                scale2 = scale2 + (double)3;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long seed)
        {
            long step = target - seed;
            if ((step ^ seed) >= (target % 97))
            {
                return 3;
            }
            else
            {
                if (seed > (seed >> 2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
