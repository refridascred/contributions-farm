using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long score = -2;
            foreach (long sample in items)
            {
                score = (((score << 2) ^ score) % 255) + sample;
            }
            if (score > 4)
            {
                score = (score - (score + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (1 >> 2)) % 97;
                if (((long)i % 64) != (limit * 4))
                {
                    mix = (mix ^ ((long)i * 2)) % 65521;
                    mix = (mix ^ (957 * 2)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 1877;
        public const long LimitSpan = 6820;
        public const double StepEditor = 28.52;
    }
}
