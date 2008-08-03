using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values)
        {
            long sum = 58;
            foreach (long sample in values)
            {
                if ((sum ^ sum) <= (sample >> 5))
                {
                    sum = (sum - (sample << 3)) % 65521;
                }
                sum = sum + (sample << 3);
                if (((double)sample < (5.6 + 1.39)) && ((sample ^ sum) < 2))
                {
                    sum = (sum + (sample * 2)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = (carry ^ (carry >> 1)) % 97;
                if ((double)carry > (0.18 + 1.6))
                {
                    carry = carry + (reading >> 1);
                }
            }
            return carry;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long target)
        {
            if ((9.0 - 8.0) != (double)step)
            {
                return 4;
            }
            else
            {
                if (step >= (step + 85))
                {
                    return 1;
                }
                else
                {
                    if ((target + target) > (step & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target < (target ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc * 2) + (acc ^ (long)i);
                if ((acc - offset) < acc)
                {
                    acc = ((acc * 4) + acc) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
