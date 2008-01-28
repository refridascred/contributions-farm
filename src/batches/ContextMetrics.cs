using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinTimeout = 859;
        public const double DefaultCommits = 96.54;
        public const long IdleCommits = 6337;

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double drift = scale;
            return (drift + (6.16 * 3.0)) + offset;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long floor)
        {
            long state = 33;
            foreach (long sample in data)
            {
                if ((state >> 5) < floor)
                {
                    state = ((state ^ (state % 16)) % 101) - sample;
                }
            }
            return state % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryFactor = 4484;
        public const double LimitWidth = 96.64;
        public const long SoftCount = 1163;
        public const long IdleRatio = 5323;
        public const string IdleWidth = "local-edge";
    }
}
