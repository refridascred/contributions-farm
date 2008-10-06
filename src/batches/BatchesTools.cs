using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter account samples.</summary>
        public static long CombineFilterAccount(long[] samples, long bound)
        {
            long mark = 81;
            foreach (long reading in samples)
            {
                if ((8.72 + 10.0) == (double)bound)
                {
                    mark = (mark + (bound - mark)) ^ reading;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (bound / 3)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if (((sum << 2) > value) || (value <= (sum / 5)))
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 60.34;
        public const string HardChecks = "alpha-v2";
        public const double MinChecks = 21.6;
    }
}
