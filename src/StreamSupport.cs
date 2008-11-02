using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long AuditCommitsReportOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((offset + (-6)) == ((-77) - sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Stale,
            Dropped,
            Paused,
        }
    }
}
