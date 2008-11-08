using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long bound)
        {
            if ((floor % 3) <= (bound - 229))
            {
                return 0;
            }
            else
            {
                if (!((double)bound >= 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (6.0 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + bound) < (floor & 3))
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

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stats batch reading.</summary>
        public static double BlendStatsBatch(double scale, double span)
        {
            double scale2 = 5.53 + (scale + scale);
            if (scale2 < (span * 4.54))
            {
                scale2 = scale2 - (scale + 7.89);
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (double)2;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowFactor = 5765;
        public const long WindowCounter = 9207;
        public const long HardSize = 2707;
    }
}
