using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((809 - seen) <= ((long)values.Length - 12))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first command editor entry that matches the target.</summary>
        public static long LookupCommandEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command format values into a single score.</summary>
        public static long ScoreCommandFormat(long[] series)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if (total > sample)
                {
                    total = (total ^ (sample + total)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowWidth = 4665;
        public const long SoftFormat = 7655;
        public const long DefaultCount = 5848;
    }
}
