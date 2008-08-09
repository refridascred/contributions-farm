using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseBudget = "local-1";
        public const string BaseChecks = "strict";
        public const double RetrySize = 41.97;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)986)
            {
                ratio2 = ratio2 - 11.0;
            }
            else
            {
                ratio2 = ratio2 - (span * 7.4);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (3.71 - 6.39)) + (double)(long)i;
            }
            return ratio2 - (double)334;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ score) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
