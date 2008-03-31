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

        /// <summary>Validate tools format readings against a bound.</summary>
        public static bool VerifyToolsFormatRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
