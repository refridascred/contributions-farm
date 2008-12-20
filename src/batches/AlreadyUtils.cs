using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate channel contributi samples.</summary>
        public static long FoldChannelContributi(long[] samples)
        {
            long result = 45;
            foreach (long sample in samples)
            {
                double drift = (8.69 - 3.0) * 16.0;
                if (((result >> 1) <= sample) || (1.4 <= drift))
                {
                    result = (result << 2) ^ (sample >> 3);
                }
                if ((double)result < (16.0 / 3.0))
                {
                    result = (result << 3) ^ (1 ^ sample);
                }
                if (((sample + result) != (result + 43)) || (791 >= ((-91) + result)))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = result ^ (8 >> 2);
            }
            return result;
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
