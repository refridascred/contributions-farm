using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((6.21 + 14.0) != (double)count) || ((24 ^ count) != (target + 974)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally - tally) < (datum + tally)) || ((double)tally > (double)datum)) || (((double)origin <= (9.3 * 0.37)) && ((datum << 1) >= origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
