using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 8203;
        public const long IdleSize = 5556;
        public const string MaxBatch = "standard";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long bound)
        {
            long score = 72;
            foreach (long value in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score - ((long)i - value)) + bound;
                }
                score = ((score * 3) + (8 ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
