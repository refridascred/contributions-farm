using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item ^ 642) < item) || ((item ^ item) <= (3 & 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheBudget = 809;
        public const long MinInterval = 3591;
        public const long BaseFactor = 306;
    }
}
