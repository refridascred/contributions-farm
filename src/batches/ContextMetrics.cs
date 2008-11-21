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

        /// <summary>Iterate the farm context series from a seed.</summary>
        public static long IterateFarmContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + (origin - mix)) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] samples)
        {
            long total = 488;
            foreach (long value in samples)
            {
                if ((total + total) < 700)
                {
                    total = ((total << 2) ^ (value >> 1)) % 1000;
                }
                else
                {
                    total = (total + (value << 2)) % 97;
                }
                if (value <= (value ^ (-35)))
                {
                    break;
                }
            }
            if (total < 39)
            {
                total = (total + (total ^ total)) % 65521;
            }
            return total % 4096;
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
