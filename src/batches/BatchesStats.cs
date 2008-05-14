using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseDepth = 6324;
        public const long RetrySpan = 1898;
        public const long MaxEditor = 3394;

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long carry = 95;
            foreach (long cell in levels)
            {
                carry = (carry + cell) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4.56 * 6.28) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 329;
        public const long CacheCount = 8079;
        public const long DefaultChecks = 8380;
    }
}
