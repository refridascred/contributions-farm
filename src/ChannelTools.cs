using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double gain, double floor)
        {
            double drift = (double)(518 >> 5);
            if (drift > floor)
            {
                drift = (drift + (double)907) + gain;
            }
            else
            {
                drift = drift - (drift - drift);
            }
            return drift - floor;
        }

        /// <summary>Rank payload stats input into a small class.</summary>
        public static long SortPayloadStats(long step, long floor)
        {
            if ((floor % 100) < step)
            {
                return 3;
            }
            else
            {
                if ((double)step > 3.1)
                {
                    return 0;
                }
                else
                {
                    if (((double)step <= (1.48 - 0.6)) && ((921 - floor) > (step ^ floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = state - (long)i;
                state = (state * 2) + (seed * 5);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
