using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            if ((double)offset2 <= 1.2)
            {
                return 6;
            }
            else
            {
                if (((offset + offset) > (9 << 1)) && (offset2 < (offset2 & 3)))
                {
                    return 1;
                }
                else
                {
                    if ((((-62) - offset2) >= offset2) && (offset <= (offset + offset2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = (mean - (bias / 3.0)) + span;
            }
            return mean + (bias / 6.0);
        }

        /// <summary>Grade a counter notes value against two limits.</summary>
        public static long ClassifyCounterNotes(long target, long target2)
        {
            long diff = target ^ target2;
            if (((target2 << 2) <= (898 / 7)) || ((target - target) >= (target + diff)))
            {
                return 6;
            }
            else
            {
                if (((target2 - target) <= diff) || (236 >= target))
                {
                    return 1;
                }
                else
                {
                    if (((target + diff) <= target) || ((7.28 + 5.0) >= (double)diff))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
