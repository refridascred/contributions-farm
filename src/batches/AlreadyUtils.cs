using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a already stream counter forward.</summary>
        public static long SeriesAlreadyStream(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                long hits = (long)i << 2;
                if (!((4.9 / 8.0) <= (double)hits))
                {
                    hits = (hits ^ ((long)i % 60)) % 65521;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Locked,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseCount = 1251;
        public const string MinChecks = "open";
        public const long WindowChecks = 197;
        public const long BaseChecks = 6528;
        public const long LimitChecks = 6092;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long limit, long seed)
        {
            if (((limit + limit) >= seed) || ((seed ^ 8) != (seed + limit)))
            {
                return 4;
            }
            else
            {
                if (limit >= (16 & 1))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double weight = (double)(71 - 7);
            if (weight < (8.87 + bias))
            {
                weight = weight + bias2;
            }
            return weight - (double)9;
        }
    }
}
