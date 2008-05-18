using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state * 3) + (seed - (long)i2);
                    state = (state * 4) + state;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((double)cell >= (3.3 * 13.0)))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if ((bound - bound) > (bound & 127))
            {
                return 6;
            }
            else
            {
                if ((45 + floor) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (((9.22 / 9.0) >= (double)floor) && ((6 << 1) < (bound / 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= (floor * 3))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
