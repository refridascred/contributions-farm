using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if ((cell >> 5) > result)
                {
                    result = result - 687;
                }
                else
                {
                    result = ((result * 2) + cell) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Stale,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first stream notes entry that matches the target.</summary>
        public static long LookupStreamNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long TallyBatchesCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen != (4.0 - 7.15))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
