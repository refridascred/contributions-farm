using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "primary";
        public const double CacheDepth = 1.71;
        public const double StepScore = 94.96;
        public const double RetryRatio = 39.68;

        /// <summary>Roll a metrics queue counter forward.</summary>
        public static long DeriveMetricsQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i != (double)6)
                {
                    carry = carry + (67 << 1);
                    carry = carry ^ (carry * 4);
                    break;
                }
                else
                {
                    carry = (carry * 5) + (bound * 5);
                }
                carry = ((carry << 3) ^ carry) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
