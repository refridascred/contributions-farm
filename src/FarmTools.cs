using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6094;
        public const long CacheSize = 6769;
        public const long DefaultFilter = 6963;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
