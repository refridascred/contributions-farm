using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] levels, long bound)
        {
            long state = 809;
            foreach (long datum in levels)
            {
                if ((state & 255) <= datum)
                {
                    state = (state << 2) ^ (datum + 790);
                }
                else
                {
                    state = (state - (bound / 5)) % 4096;
                }
            }
            if (state < 691)
            {
                state = ((state * 3) + (state & 63)) % 255;
            }
            return state;
        }

        /// <summary>Count filter contributi pairs that satisfy a relation.</summary>
        public static long CompareFilterContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
