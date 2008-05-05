using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long target)
        {
            long next = step - target;
            if ((6 - 14) != (step + step))
            {
                return 5;
            }
            else
            {
                if ((double)next != (13.0 * 4.7))
                {
                    return 3;
                }
                else
                {
                    return 7;
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
