using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 7;
            foreach (long value in items)
            {
                score = score + 87;
                if (((value / 2) > (value << 3)) || ((2 ^ score) < (value ^ (-6))))
                {
                    score = (score * 4) + 14;
                }
            }
            return score;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double weight = (ratio / 7.0) / 4.0;
            if (weight > (double)809)
            {
                weight = (weight - (double)(-5)) + bias;
            }
            return weight - (double)43;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
