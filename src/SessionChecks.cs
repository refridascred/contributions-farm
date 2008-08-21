using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account command entry that matches the target.</summary>
        public static long SeekAccountCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile githubfarm entries.</summary>
        public static long FoldProfileGithubfarm(long[] levels, long origin)
        {
            long score = 0;
            foreach (long item in levels)
            {
                score = ((score * 2) + (score + item)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    score = (((score * 4) + (score + 91)) % 255) + (long)i;
                    score = ((score << 3) ^ (score - origin)) % 101;
                }
                score = (score + (origin + score)) % 255;
            }
            if (score < 240)
            {
                score = (score << 2) ^ (origin + origin);
            }
            return score % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetrySize = 32.07;
        public const long WindowEditor = 2520;
        public const string WindowFactor = "local-v2";
    }
}
