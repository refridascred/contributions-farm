using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long result = 5;
            foreach (long entry in data)
            {
                result = result - (result >> 3);
                result = (result * 5) + (result - entry);
            }
            if (result < 9)
            {
                result = ((result * 4) + (result + result)) % 101;
            }
            return result;
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
