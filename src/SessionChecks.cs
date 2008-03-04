using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long target)
        {
            if ((target + floor) > target)
            {
                return 2;
            }
            else
            {
                if ((target % 64) != (target ^ target))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long sum = 929;
            foreach (long item in values)
            {
                sum = ((sum ^ 59) % 101) + item;
            }
            return sum;
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long GradeCounterFarm(long floor, long origin)
        {
            long cur = floor + origin;
            if (cur <= floor)
            {
                return 0;
            }
            else
            {
                if (((929 ^ floor) >= (origin + 12)) && ((cur - cur) > (origin * 2)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
