using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long seed)
        {
            long edge = floor - seed;
            if (edge <= floor)
            {
                return 3;
            }
            else
            {
                if ((37 + floor) > (edge >> 1))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double bias)
        {
            double load = bias * 9.0;
            if (load <= (double)0)
            {
                load = load - (double)3;
            }
            else
            {
                load = load + (11.0 + rate);
            }
            return load + load;
        }
    }
}
