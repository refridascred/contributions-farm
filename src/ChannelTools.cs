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

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFactor = 54.81;
        public const long BurstLevel = 134;
        public const long WindowFormat = 9307;
        public const double WindowRatio = 2.48;
        public const string IdleFormat = "staging-1";

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
