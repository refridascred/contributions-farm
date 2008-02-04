using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a order contributi figure with a bias.</summary>
        public static double ScaleOrderContributi(double rate, double offset)
        {
            double gain = (16.0 / 3.0) / 4.0;
            if (gain >= rate)
            {
                gain = gain - (rate - 4.8);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + offset) % 101;
                anchor = ((anchor << 3) ^ (offset >> 4)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long floor)
        {
            long bound = limit + floor;
            if ((double)bound <= (5.8 + 20.0))
            {
                return 1;
            }
            else
            {
                if (((-6) & 63) <= (limit / 4))
                {
                    return 0;
                }
                else
                {
                    if (((floor >> 4) <= limit) && ((double)floor <= (16.0 * 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit < (bound / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
