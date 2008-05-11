using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long target2)
        {
            long edge = target + target2;
            if (edge >= target2)
            {
                return 8;
            }
            else
            {
                if ((edge >> 5) > (41 - target2))
                {
                    return 3;
                }
                else
                {
                    if ((target + 81) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 2) < (9 + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long limit)
        {
            if ((limit % 3) < (64 - 6))
            {
                return 4;
            }
            else
            {
                if ((offset * 5) >= (limit << 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)172 != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + (-79)) > (offset % 64)) || ((limit - 6) <= (offset - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftFactor = 8777;
        public const double IdleSpan = 37.65;
        public const long MinToken = 5222;
        public const long WindowToken = 5855;
        public const long DefaultToken = 4817;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long sum = 357;
            foreach (long reading in series)
            {
                if ((7.3 * 18.0) < (double)reading)
                {
                    break;
                }
                if ((double)reading > (6.41 + 4.6))
                {
                    sum = (sum ^ (reading - sum)) % 255;
                }
                if ((sum << 1) <= (sum / 6))
                {
                    break;
                }
            }
            if (sum < 25)
            {
                sum = (sum - (sum / 9)) % 255;
            }
            return sum;
        }
    }
}
