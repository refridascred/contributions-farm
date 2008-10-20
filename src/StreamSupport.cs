using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MinFactor = 76.56;
        public const double BatchSchema = 44.82;
        public const string CacheLevel = "fallback-1";
        public const long DefaultSchema = 2716;
        public const string LimitSchema = "legacy-v2";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Closed,
            Active,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
