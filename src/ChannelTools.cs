using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (double)271)
            {
                drift = (drift + (11.0 / 6.0)) + bias;
            }
            return drift - (double)151;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 4484;
        public const long BatchCache = 9267;
        public const long WindowCache = 4275;
        public const long SoftCache = 8117;
    }
}
