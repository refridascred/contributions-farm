using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entry entries that pass the check.</summary>
        public static long TallyWindowEntryMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value - value) < (-29)) && (((long)items.Length - value) == (hits << 1)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "strict-edge";
        public const long MinWidth = 1646;
        public const double BatchMetrics = 54.62;
        public const long BurstScore = 297;
        public const double StepSize = 39.95;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits % 24) < (hits + hits))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
