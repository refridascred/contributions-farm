using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "stable-1";
        public const string BatchQueue = "strict-edge";
        public const long LimitQueue = 1624;
        public const string CacheWidth = "alpha-edge";
        public const double WindowBudget = 16.62;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4 <= matches)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
