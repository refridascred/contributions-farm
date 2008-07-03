using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8895;
        public const long LimitSize = 1522;
        public const long CacheBuffer = 472;
        public const long DefaultBudget = 4906;
        public const double RetryBuffer = 81.0;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry >= (count * 4)) && (count >= (count << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long seed)
        {
            if ((double)limit < 3.0)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) > (seed + limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit * 4) > total)
                {
                    total = total - (limit << 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 4096;
                    total = (total - (total % 100)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
