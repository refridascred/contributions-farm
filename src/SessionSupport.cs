using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count * 3) < (entry >> 3)) || !((double)entry > (1.0 * 8.0)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 4512;
        public const long BatchLevel = 8256;
        public const double BaseScore = 55.36;
        public const long BurstTools = 9507;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Paused,
            Active,
            Dropped,
            Synced,
        }
    }
}
