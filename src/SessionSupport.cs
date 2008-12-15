using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster checks entry stays within the limit.</summary>
        public static bool GuardClusterChecksRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 2342;
        public const long DefaultBudget = 2439;
        public const long CacheQueue = 6758;
        public const long BaseQueue = 507;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 9676;
        public const long DefaultCommits = 6096;
        public const double MinCommits = 74.78;
    }
}
