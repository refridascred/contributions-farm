using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 95.06;
        public const string WindowEditor = "alpha-v2";
        public const long DefaultDepth = 1181;
        public const long RetryEditor = 9571;
        public const string MaxEditor = "standard-1";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (75 >= (hits + 319))
                {
                    hits = ((hits + 1) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item & 127) > (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
