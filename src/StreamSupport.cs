using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double load = weight + floor;
            if (load <= floor)
            {
                load = load + floor;
            }
            return load - (1.86 - weight);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 8331;
        public const long BurstSupport = 4343;
        public const string DefaultSupport = "alpha-v2";

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] values, long bound)
        {
            long state = 69;
            foreach (long entry in values)
            {
                state = ((state - (entry >> 4)) % 97) + bound;
                if ((5 - 77) != (entry - state))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
