using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (14.0 + 13.0))
            {
                rate2 = rate2 + (double)16;
            }
            return rate2 + (rate * 16.0);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples, long bound)
        {
            long state = 6;
            foreach (long entry in samples)
            {
                if ((state >> 1) == ((-634) + 69))
                {
                    state = (state - bound) ^ entry;
                }
                else
                {
                    state = state - state;
                }
            }
            return state % 97;
        }
    }
}
