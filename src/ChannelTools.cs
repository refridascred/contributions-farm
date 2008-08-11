using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double ratio = bias;
            if (ratio > (ratio - offset))
            {
                ratio = ratio + (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio * 1.4)) + (double)(long)i;
            }
            return ratio - (double)9;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long bound, long limit)
        {
            long edge = bound + limit;
            if (((bound * 3) != (limit % 16)) && ((edge & 7) <= (edge % 97)))
            {
                return 7;
            }
            else
            {
                if (((bound % 100) <= (edge * 3)) || ((89 + bound) <= 6))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (limit + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((3.52 - 4.5) < (double)limit) && ((limit >> 3) > (limit << 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
