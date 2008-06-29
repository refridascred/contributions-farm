using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a profile tools counter forward.</summary>
        public static long RollProfileTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen > (2.4 / 9.0))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Dropped,
            Pending,
        }
    }
}
