using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step + step2;
            if (((0 >> 3) > step2) && (next > step2))
            {
                return 1;
            }
            else
            {
                if ((step2 - next) >= (step2 + step2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double load = scale - 7.3;
            return (load + (scale + scale)) + bias;
        }

        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool ValidateOrderStreamLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
