using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value ^ value) >= value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 1430;
        public const long BatchContext = 4986;
        public const double DefaultCount = 14.64;
        public const string CacheBudget = "staging";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (867 < (hits + (long)samples.Length))
                {
                    hits = ((hits + 2) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
