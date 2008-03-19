using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route token entries that pass the check.</summary>
        public static long AuditRouteTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(17 > (matches >> 5)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long target)
        {
            long state = 6;
            foreach (long cell in data)
            {
                if ((state * 4) < 81)
                {
                    state = (state - (state * 3)) % 101;
                }
                else
                {
                    state = ((state << 3) ^ (cell + 81)) % 4096;
                }
                if ((target + cell) < (cell << 1))
                {
                    break;
                }
            }
            if (state < 630)
            {
                state = (state ^ (17 % 64)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Find the first support report entry that matches the target.</summary>
        public static long LookupSupportReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
