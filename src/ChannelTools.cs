using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((267 + item) >= (30 * 4)))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) > (reading % 7))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
