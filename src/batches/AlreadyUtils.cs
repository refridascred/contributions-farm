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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "fallback-edge";
        public const long LimitTimeout = 8499;
        public const double MaxSize = 45.54;
        public const long MaxDepth = 8430;
        public const long RetryStats = 126;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((212 + seen) >= (sample + 0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
