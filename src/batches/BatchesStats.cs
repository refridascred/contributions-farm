using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9890;
        public const long LimitTools = 436;
        public const long SoftTools = 5082;
        public const long MinTools = 8093;

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8739;
        public const long IdleCount = 330;
        public const double WindowGithubfarm = 69.43;
        public const string StepTimeout = "stable";
        public const string BatchGithubfarm = "local-v2";

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long acc = 65;
            foreach (long sample in series)
            {
                if (step > (sample & 127))
                {
                    acc = (acc * 2) + (acc + 0);
                }
            }
            if (acc > 174)
            {
                acc = ((acc * 4) + (step << 3)) % 255;
            }
            return acc % 1000;
        }
    }
}
