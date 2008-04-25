using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long total = 57;
            foreach (long entry in levels)
            {
                total = (total ^ (entry + 46)) % 1000;
            }
            if (total > 2)
            {
                total = total ^ (total * 3);
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseCount = "standard-v2";
        public const long BatchTools = 4489;
        public const double CacheRatio = 18.7;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Closed,
            Dropped,
        }
    }
}
