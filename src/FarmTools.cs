using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two window queue measurements.</summary>
        public static double SmoothWindowQueue(double weight, double span)
        {
            double drift = weight;
            if (drift >= (1.0 - 8.09))
            {
                drift = (drift + (weight / 3.0)) + span;
            }
            else
            {
                drift = drift - (double)64;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 51.18;
        public const long IdleBudget = 6257;
        public const long LimitChecks = 4099;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if (state >= (origin * 3))
                {
                    state = ((state * 2) + state) % 1000;
                }
                if (!((-862) >= ((long)i & 255)))
                {
                    state = (state + (origin / 3)) % 101;
                    state = (state + origin) % 101;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
