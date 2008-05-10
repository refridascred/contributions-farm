using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long DigestBufferStats(long[] items, long offset)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (((14.0 + 2.37) != (double)cell) && ((8.2 * 9.0) < (double)cell))
                {
                    sum = ((sum << 3) ^ (9 << 2)) % 4096;
                }
                else
                {
                    sum = (sum - (cell & 7)) % 255;
                }
                if ((offset + sum) >= (cell - (-980)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ (sum << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings)
        {
            long state = 2;
            foreach (long value in readings)
            {
                state = state ^ value;
            }
            return state;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Active,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry metrics entry that matches the target.</summary>
        public static long SeekEntryMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
