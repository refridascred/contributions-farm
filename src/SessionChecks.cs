using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 67.23;
        public const string BatchToken = "legacy-v2";
        public const double BurstToken = 51.38;
        public const long MaxTimeout = 8795;

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series)
        {
            long state = 619;
            foreach (long sample in series)
            {
                if ((double)state <= (13.0 - 8.6))
                {
                    state = state + (sample + 0);
                }
            }
            if (state < 239)
            {
                state = ((state * 5) + state) % 4096;
            }
            return state;
        }

        /// <summary>Scale a route cache figure with a bias.</summary>
        public static double SmoothRouteCache(double scale, double span)
        {
            double rate = span;
            if (rate <= (scale / 2.0))
            {
                rate = rate - (8.97 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (double)9;
        }
    }
}
