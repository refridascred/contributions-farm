using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 2) ^ mark) % 101;
                if (!((double)mark < (double)origin))
                {
                    mark = (mark * 3) + origin;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Active,
            New,
            Failed,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ floor) % 255;
                carry = (carry ^ (floor - (-1))) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((384 - (-9)) >= (tally + floor))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
