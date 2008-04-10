using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardTimeout = 4720;
        public const long IdleBudget = 5455;
        public const long RetryProfile = 5343;
        public const long CacheProfile = 3995;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)target < (6.0 * 11.0)) || ((double)count <= (10.0 / 6.0)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((limit + reading) <= (tally + 295)) && (reading > (84 << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Active,
            Failed,
            Pending,
            New,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((8.3 + 3.0) > (double)datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
