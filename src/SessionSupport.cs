using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long seed)
        {
            if ((double)seed >= (double)offset)
            {
                return 7;
            }
            else
            {
                if (((-8) - offset) <= (seed + offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double rate = (double)35;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (11.0 + span);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const double MaxGraph = 47.71;
        public const long HardInterval = 551;
    }
}
