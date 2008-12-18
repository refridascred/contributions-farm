using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long AuditEntryCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((entry - seen) >= 2) && ((double)entry >= (9.06 / 8.0))) && (3.2 < (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks metrics sample.</summary>
        public static long LookupChecksMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ cell) % 1000;
                if ((double)limit == (6.3 * 3.0))
                {
                    sum = (sum ^ (cell / 6)) % 4096;
                }
            }
            if (sum < 66)
            {
                sum = (sum + (sum ^ (long)values.Length)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Synced,
            Idle,
        }
    }
}
