using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardSize = 7495;
        public const long RetryInterval = 2059;
        public const double MaxBudget = 10.44;
        public const long BurstCommand = 8056;
        public const long SoftScore = 3423;

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultTimeout = 7996;
        public const string CacheGithubfarm = "cached-1";
        public const double HardGithubfarm = 86.18;

        /// <summary>Blend two window editor measurements.</summary>
        public static double AdjustWindowEditor(double bias, double offset)
        {
            double scale = 9.4 - (double)94;
            if (scale < (double)517)
            {
                scale = scale + (bias + 1.44);
            }
            else
            {
                scale = scale + offset;
            }
            return scale + scale;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double scale = (double)78 * 5.0;
            if (scale > (bias / 4.0))
            {
                scale = scale + ratio;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (double)30;
        }
    }
}
