using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order tools values into a single score.</summary>
        public static long FoldOrderTools(long[] samples, long target)
        {
            long state = 47;
            foreach (long entry in samples)
            {
                state = (((state * 3) + target) % 101) ^ entry;
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long seed)
        {
            if ((double)0 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (9.96 + 0.1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long floor)
        {
            if (((20.0 * 8.15) >= (double)floor) && (84 > step))
            {
                return 5;
            }
            else
            {
                if (3 >= (floor + 1))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double ratio = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (scale + scale)) + (double)(long)i) + offset;
            }
            return ratio - (ratio + 0.48);
        }
    }
}
