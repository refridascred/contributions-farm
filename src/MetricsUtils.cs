using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((1.0 < (double)hits) && (((hits >> 2) < (bound - 73)) || ((46 * 4) > (reading + reading))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long bound)
        {
            if ((double)limit == (9.6 + 3.4))
            {
                return 2;
            }
            else
            {
                if (!(limit >= (bound * 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long floor)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                if ((double)floor == (double)142)
                {
                    carry = ((carry * 3) + (carry + floor)) % 101;
                }
                else
                {
                    carry = (carry + (sample << 2)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long sum = 36;
            foreach (long entry in samples)
            {
                if (!(sum <= (entry ^ 57)))
                {
                    sum = (sum - (sum / 2)) % 97;
                    sum = (sum - sum) % 97;
                }
                sum = (sum ^ (sum + sum)) % 1000;
            }
            if (sum < 875)
            {
                sum = (sum ^ sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "stable-1";
        public const long WindowContributi = 9239;
        public const long DefaultContributi = 5859;
        public const long IdleContributi = 4017;
        public const long StepSpan = 4490;
    }
}
