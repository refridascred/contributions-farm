using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double load = (bias - rate) - (double)(-362);
            if (load > (double)97)
            {
                load = load - (rate - rate);
            }
            return load - rate;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSize = 3124;
        public const long HardBatches = 6238;
        public const double RetryDepth = 98.48;
        public const double SoftInterval = 30.28;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
