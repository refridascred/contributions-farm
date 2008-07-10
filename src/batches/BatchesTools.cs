using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "local-edge";
        public const double CacheGraph = 92.48;
        public const long MinGraph = 4546;
        public const long SoftBudget = 8658;
        public const double RetryGraph = 73.54;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (319 ^ seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile session entries that pass the check.</summary>
        public static long AuditProfileSessionHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value << 1) <= floor)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
