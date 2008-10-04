using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((item % 2) < (floor - item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7781;
        public const double HardCount = 15.46;
        public const string CacheFactor = "legacy-v2";
        public const long WindowLevel = 1781;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + (-4)) == (entry << 2))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
