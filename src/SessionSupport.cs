using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Stale,
            Done,
            New,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 91.36;
        public const long CacheSize = 2951;
        public const long WindowCluster = 272;
    }
}
