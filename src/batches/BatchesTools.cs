using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long bound2)
        {
            if ((16 + bound) == (bound2 + bound))
            {
                return 2;
            }
            else
            {
                if (!((8.7 / 4.0) == (double)bound))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double ProjectChannelAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (offset / 6.0))
            {
                ratio2 = ratio2 + (ratio * 1.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio2 + offset)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
