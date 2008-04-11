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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits < (hits + sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] samples)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)(long)samples.Length)
                {
                    sum = (sum ^ sum) % 255;
                }
                else
                {
                    sum = (sum - (entry - 5)) % 101;
                }
            }
            return sum;
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
