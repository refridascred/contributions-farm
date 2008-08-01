using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(384 >= (reading * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
