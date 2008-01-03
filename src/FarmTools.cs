using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double scale = (rate * 3.41) / 9.0;
            if (scale <= scale)
            {
                scale = scale - (bias * 6.81);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale - 7.8)) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long target)
        {
            if (((target + target) == (seed & 63)) && ((5.2 - 2.0) >= (double)target))
            {
                return 3;
            }
            else
            {
                if ((target & 3) > target)
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (0.3 + 5.88))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= (7.0 - 9.95))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
