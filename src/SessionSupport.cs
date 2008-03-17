using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 842;
        public const long BurstSpan = 1856;
        public const long BaseFactor = 2250;

        /// <summary>Validate entry cluster readings against a bound.</summary>
        public static bool VerifyEntryClusterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Active,
            Idle,
            Stale,
            Draft,
        }
    }
}
