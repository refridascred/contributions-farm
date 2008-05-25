using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((double)edge < 4.0)
            {
                return 4;
            }
            else
            {
                if (9.8 <= (double)edge)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count <= (6.16 * 5.0))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double bias)
        {
            double scale = rate * 9.17;
            if (scale <= scale)
            {
                scale = (scale - (rate / 2.0)) - bias;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
