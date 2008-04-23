using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleCount = 84.33;
        public const long RetryFactor = 1940;
        public const double SoftGithubfarm = 62.73;
        public const string StepSize = "local-1";
        public const long BurstFactor = 4744;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry < (236 + origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long carry = 296;
            foreach (long datum in items)
            {
                if ((datum - datum) == (carry & 255))
                {
                    carry = (carry + (carry ^ datum)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + (datum % 97)) % 101;
                }
            }
            return carry;
        }
    }
}
