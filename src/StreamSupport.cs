using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheScore = 4353;
        public const long IdleLevel = 2624;
        public const long RetryDepth = 1029;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            New,
            Queued,
            Draft,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
