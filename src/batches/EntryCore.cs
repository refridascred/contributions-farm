using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of contributi route readings.</summary>
        public static long WeighContributiRoute(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (cell >= (result % 5))
                {
                    result = result ^ cell;
                }
            }
            return result;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 6329;
        public const long BatchBuffer = 2146;
        public const double DefaultSize = 65.98;
        public const long MinBuffer = 3370;
        public const double SoftBudget = 40.27;
    }
}
