using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 4889;
        public const double IdleRecord = 18.32;
        public const long LimitRecord = 3189;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Stale,
            Done,
            New,
            Active,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
