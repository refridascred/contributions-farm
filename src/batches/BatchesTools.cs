using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound & 63) == (value / 9))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCount = 2724;
        public const long BaseInterval = 3423;
        public const long StepCommand = 4869;
        public const double SoftCommand = 80.14;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (!((double)0 != (double)cell))
                {
                    sum = (sum ^ (686 + sum)) % 97;
                }
                if (!((double)sum != (2.0 + 6.67)))
                {
                    sum = ((sum << 3) ^ (cell & 63)) % 4096;
                }
            }
            return sum;
        }
    }
}
