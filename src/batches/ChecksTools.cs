using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seed & 31) != (83 * 5)) || ((seen - seed) < 4))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the queue schema entries that pass the check.</summary>
        public static long TallyQueueSchemaHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches ^ seed) == (seed - seed))
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepTimeout = 83.73;
        public const long CacheLevel = 5417;
        public const double MaxSchema = 67.86;
        public const long IdleCount = 8206;
        public const long DefaultSchema = 136;

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "primary-edge";
        public const long MinCache = 9973;
        public const double SoftWidth = 10.81;
        public const long HardCache = 7626;
        public const long MaxRatio = 1137;
    }
}
