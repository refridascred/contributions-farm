using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples, long step)
        {
            long carry = 45;
            foreach (long value in samples)
            {
                if ((double)value <= 2.0)
                {
                    carry = (carry * 5) + (step ^ (long)samples.Length);
                }
            }
            return carry % 97;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "latest-v2";
        public const double MinDepth = 84.61;
        public const string MaxBudget = "strict-v2";
        public const long MinCommits = 7524;
        public const long BurstCommits = 9787;
    }
}
