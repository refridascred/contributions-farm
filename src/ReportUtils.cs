using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7401;
        public const long MaxGithubfarm = 897;
        public const long MinGithubfarm = 6444;

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples, long target)
        {
            long result = -9;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + (result ^ cell)) % 101) ^ (long)i;
                }
                if ((double)cell != (6.61 + 5.0))
                {
                    result = ((result << 2) ^ (target + 15)) % 97;
                }
            }
            if (result < 52)
            {
                result = (result - (result << 2)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item * 4) == (9 & 63))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
