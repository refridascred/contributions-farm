using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchBudget = 8.91;
        public const long DefaultWidth = 2756;
        public const long BaseRatio = 8422;
        public const long StepWidth = 7337;

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score ^ (score ^ score)) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Paused,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowCount = 4.49;
        public const long DefaultEditor = 5668;
        public const double CacheScore = 21.2;
        public const string SoftEditor = "cached-1";
        public const long SoftRatio = 1673;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Synced,
            New,
            Dropped,
            Locked,
        }
    }
}
