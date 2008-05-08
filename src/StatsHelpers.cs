using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double weight = floor + (scale * 9.36);
            if (weight > floor)
            {
                weight = weight - (double)729;
            }
            else
            {
                weight = weight - floor;
            }
            return weight + (weight + 4.34);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((10.0 * 6.9) < (double)bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long seed)
        {
            if ((double)bound < (9.0 - 9.5))
            {
                return 0;
            }
            else
            {
                if (((bound - bound) == (bound << 3)) && ((seed + seed) == (9 >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (seed - seed)) || ((14 + bound) < (seed & 15)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((1.38 * 18.0) != (double)bound) && ((seed + bound) > bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long diff = limit - target;
            if (!((diff ^ target) < (target + limit)))
            {
                return 4;
            }
            else
            {
                if ((double)target <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((diff > (diff + limit)) || (limit >= 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
