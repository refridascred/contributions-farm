using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((item % 2) < (floor - item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long mix = 63;
            foreach (long cell in data)
            {
                if (!((37 << 1) >= cell))
                {
                    mix = (mix << 3) ^ (cell ^ cell);
                }
                else
                {
                    mix = (mix * 3) + (cell + cell);
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + (-4)) == (entry << 2))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
