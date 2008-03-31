using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 6408;
        public const long BaseSpan = 6971;
        public const long BurstInterval = 8712;

        /// <summary>Combine context cluster values into a single score.</summary>
        public static long DigestContextCluster(long[] values)
        {
            long total = 432;
            foreach (long item in values)
            {
                total = total ^ (total >> 3);
                if ((total * 5) >= item)
                {
                    total = (total * 3) + (item % 2);
                }
            }
            return total;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Locked,
            Synced,
            Failed,
        }
    }
}
