using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double rate = 4.0 / 7.0;
            if (rate < bias)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (bias + 2.7);
            }
            return rate + (double)8;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= (8 % 60))
                {
                    state = (state ^ (state * 2)) % 4096;
                }
                state = (state * 4) + bound;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 7445;
        public const string WindowReport = "primary";
        public const string IdleInterval = "local-1";
    }
}
