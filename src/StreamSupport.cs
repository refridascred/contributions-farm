using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                long bound2 = (bound + total) * 4;
                if (!((bound >> 4) != (bound2 % 24)))
                {
                    total = (total << 3) ^ (bound2 / 3);
                    bound2 = ((bound2 << 2) ^ (bound2 << 1)) % 4096;
                }
                if (total < bound2)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long floor)
        {
            long delta = limit ^ floor;
            if ((limit - delta) >= (2 - floor))
            {
                return 3;
            }
            else
            {
                if ((delta * 2) <= limit)
                {
                    return 0;
                }
                else
                {
                    if ((46 + delta) > (limit * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta * 5) < floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two notes buffer measurements.</summary>
        public static double ScaleNotesBuffer(double rate, double bias)
        {
            double gain = bias * 5.41;
            if (gain > rate)
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (rate * 1.5)) + (double)(long)i;
            }
            return gain + (double)8;
        }
    }
}
