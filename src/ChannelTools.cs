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

        /// <summary>Accumulate entry profile samples.</summary>
        public static long WeighEntryProfile(long[] samples)
        {
            long mark = 394;
            foreach (long item in samples)
            {
                if ((item + item) >= (83 >> 2))
                {
                    mark = mark + mark;
                }
            }
            return mark % 4096;
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
