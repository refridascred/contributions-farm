using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((71 << 1) == (item >> 1))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a order schema pair into a bucket.</summary>
        public static long BucketOrderSchema(long origin, long offset)
        {
            long step = origin ^ offset;
            if (!((double)step < (double)31))
            {
                return 6;
            }
            else
            {
                if ((882 >> 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if (step < (76 % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long bound2)
        {
            if ((bound2 + bound) >= (5 >> 2))
            {
                return 3;
            }
            else
            {
                if ((bound2 >= bound) || ((-948) >= bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 4) > (bound << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.3 - 3.0) > (double)bound) || ((bound * 2) < 657))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double load = gain;
            if (load >= span)
            {
                load = load + (gain + span);
            }
            return load + (4.45 * 6.56);
        }
    }
}
