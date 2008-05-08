using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "legacy-1";
        public const string BatchWidth = "latest-v2";
        public const long SoftScore = 6118;
        public const string IdleContributi = "latest-edge";
        public const string DefaultLevel = "staging-v2";

        /// <summary>Look up the position of a counter githubfarm sample.</summary>
        public static long LocateCounterGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long state = 6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((((state + (state / 6)) % 101) ^ (long)i) - sample) - limit;
                }
                state = (state - (state & 3)) % 4096;
            }
            return state;
        }
    }
}
