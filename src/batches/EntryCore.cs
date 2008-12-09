using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of token context readings.</summary>
        public static long PairTokenContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "local-v2";
        public const long SoftWidth = 6347;
        public const long CacheNotes = 3954;
        public const double HardNotes = 65.19;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 2414;
        public const double RetryContributi = 36.01;
        public const long DefaultFactor = 7895;
        public const string MaxTimeout = "open-v2";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Stale,
            Draft,
        }
    }
}
