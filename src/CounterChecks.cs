using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long CountNotesGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 + cell) == ((long)values.Length * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4766;
        public const long BaseScore = 3035;
        public const long BurstWindow = 1048;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (total + total)) % 255;
                total = ((total * 2) + (floor / 6)) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 44.31;
        public const long BaseLevel = 6445;
        public const long RetryRatio = 9340;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Closed,
            Locked,
            Synced,
            Dropped,
        }
    }
}
