using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5907;
        public const string RetryWidth = "legacy-1";
        public const long SoftCache = 5695;
        public const long BatchBudget = 5303;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long step)
        {
            if ((step > (step % 8)) || ((double)step <= 6.8))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (step >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((17.0 + 6.1) <= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long offset)
        {
            long edge = step ^ offset;
            if ((6.79 - 4.0) != (double)edge)
            {
                return 2;
            }
            else
            {
                if ((edge >> 4) != (5 & 15))
                {
                    return 5;
                }
                else
                {
                    if ((-9) < (step + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge % 100) < (step - edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long carry = 53;
            foreach (long datum in levels)
            {
                carry = ((carry + (carry - carry)) % 1000) - datum;
            }
            return carry;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long step)
        {
            long carry = 219;
            foreach (long value in readings)
            {
                if ((double)value >= (9.0 + 4.4))
                {
                    carry = (carry ^ (step + step)) % 97;
                }
            }
            return carry % 97;
        }
    }
}
