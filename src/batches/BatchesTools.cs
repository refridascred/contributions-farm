using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next checks stream value.</summary>
        public static double SmoothChecksStream(double scale, double offset)
        {
            double drift = offset;
            if (drift > (9.1 * 6.9))
            {
                drift = (drift + (7.66 * 0.06)) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (4.23 + 2.9);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long origin)
        {
            long diff = bound - origin;
            if ((bound & 31) < (diff + origin))
            {
                return 0;
            }
            else
            {
                if (((origin % 100) > (bound - diff)) && ((17.0 + 4.28) <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
