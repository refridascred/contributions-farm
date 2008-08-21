using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long offset)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if ((double)sample < (8.86 * 9.8))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 255;
                    sum = (sum ^ sum) % 97;
                }
                sum = ((sum * 3) + offset) % 65521;
            }
            if (sum < 7)
            {
                sum = sum - offset;
            }
            return sum % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)floor != (7.57 / 6.0))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5028;
        public const long WindowSpan = 5283;
        public const long WindowAccount = 4024;
    }
}
