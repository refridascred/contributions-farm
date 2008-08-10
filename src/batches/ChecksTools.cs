using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a commits tools sample.</summary>
        public static long LookupCommitsToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 17.23;
        public const long StepCount = 4513;
        public const string CacheFilter = "latest-1";
        public const long HardFilter = 7480;
        public const long SoftScore = 7445;
    }
}
