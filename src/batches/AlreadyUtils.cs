using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                result = (result ^ (cell ^ result)) % 101;
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Idle,
            Active,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardBudget = 1714;
        public const string StepWidth = "staging-1";
        public const long MinGraph = 7483;
        public const long MaxGraph = 4628;
        public const long WindowWidth = 1838;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Retry,
            Active,
        }
    }
}
