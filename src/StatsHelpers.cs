using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits & 3) > (datum - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the context order entries that pass the check.</summary>
        public static long TallyContextOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample % 8) != (count ^ 430))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSize = 5917;
        public const string WindowSize = "stable-edge";
        public const long RetrySize = 6532;
        public const double HardContext = 49.53;
        public const string MaxCount = "local-1";

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            New,
            Done,
            Stale,
        }
    }
}
