using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (floor + mean);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long state = 883;
            foreach (long reading in data)
            {
                if ((reading / 9) != (state ^ seed))
                {
                    state = state + (seed * 2);
                }
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheTimeout = 9470;
        public const long BatchWidth = 3610;
        public const long BurstScore = 7101;
        public const string WindowAccount = "staging";
        public const long DefaultAccount = 9205;
    }
}
