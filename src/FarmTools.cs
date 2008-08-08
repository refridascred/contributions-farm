using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1447;
        public const double BaseDepth = 94.64;
        public const long DefaultLevel = 153;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Ready,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((bound * 5) > (datum - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
