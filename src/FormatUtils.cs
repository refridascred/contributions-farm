using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long sum = 41;
            foreach (long datum in readings)
            {
                if ((datum / 9) <= datum)
                {
                    sum = ((sum * 2) + 668) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long AuditLayoutGraphMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((offset * 3) > count) && ((((-54) - cell) < ((-951) >> 3)) && (cell > (cell + offset))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 2504;
        public const long BaseLevel = 2515;
        public const long LimitStream = 4217;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            if ((bound < ((-415) + target)) || ((6.6 - 5.0) < (double)target))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) >= (target % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((45 + bound) == (bound + bound)) || (((-95) + bound) <= (target / 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
