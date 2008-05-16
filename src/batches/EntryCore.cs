using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double drift = offset * 3.21;
            if (drift > 5.57)
            {
                drift = drift - rate;
            }
            return drift - 6.41;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Paused,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long sum = 918;
            foreach (long entry in samples)
            {
                if ((7.13 - 13.0) <= (double)entry)
                {
                    sum = ((sum * 4) + entry) % 65521;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 2) ^ (sum * 4)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultWidth = "legacy-v2";
        public const string BatchSize = "open-1";
        public const long BurstSpan = 2629;
        public const long LimitGithubfarm = 1557;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 7596;
        public const double RetryGithubfarm = 78.65;
        public const long SoftGithubfarm = 9789;
    }
}
