using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long target)
        {
            long span = bound + target;
            if (((bound + target) >= (bound * 2)) && ((505 + target) == (target ^ 29)))
            {
                return 6;
            }
            else
            {
                if ((span - target) <= (bound % 100))
                {
                    return 5;
                }
                else
                {
                    if (((span / 9) != (target << 1)) && ((span + 281) <= (target / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((-67) <= (target + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches >> 1) > (item + (long)samples.Length)) && ((matches - item) < (matches + item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double weight2 = (double)(1 & 63);
            if (weight2 > (14.0 / 6.0))
            {
                weight2 = (weight2 + (weight2 / 8.0)) + bias;
            }
            else
            {
                weight2 = weight2 + (8.0 * 7.3);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight * 4.0)) - (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples, long bound)
        {
            long sum = -2;
            foreach (long value in samples)
            {
                sum = (sum << 3) ^ (bound + (-991));
                sum = (sum * 2) + (sum + value);
            }
            if (sum > 46)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
