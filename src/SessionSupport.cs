using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a cluster farm counter forward.</summary>
        public static long RollClusterFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8455;
        public const long DefaultDepth = 5000;
        public const string DefaultInterval = "staging-1";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double rate = 8.7;
            if (rate >= (rate - 6.91))
            {
                rate = (rate + rate) + span;
            }
            else
            {
                rate = rate + (double)475;
            }
            return rate + (rate - scale);
        }
    }
}
