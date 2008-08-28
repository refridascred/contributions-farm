using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool CheckEntryToolsLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Synced,
            Retry,
        }
    }
}
