using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleTimeout = 22.83;
        public const long DefaultWidth = 4850;
        public const long MinCommand = 313;
        public const long MinDepth = 9988;
        public const long SoftDepth = 9863;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen >> 5) <= item))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Active,
            Retry,
        }
    }
}
