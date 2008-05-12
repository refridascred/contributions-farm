using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long seed)
        {
            if (origin <= (83 & 127))
            {
                return 6;
            }
            else
            {
                if (origin > seed)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank already notes input into a small class.</summary>
        public static long BucketAlreadyNotes(long floor, long origin)
        {
            long gap = floor - origin;
            if (!((2.0 * 2.09) == (double)floor))
            {
                return 3;
            }
            else
            {
                if ((gap >= (floor + 72)) || ((6.3 / 4.0) > (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((-82) <= (gap & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap < origin) || ((9 >> 1) >= (162 ^ floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer metric figure with a bias.</summary>
        public static double BlendBufferMetric(double bias, double bias2)
        {
            double scale = (double)(25 & 7);
            if (scale >= scale)
            {
                scale = ((scale + 2.0) - bias) - bias2;
            }
            return scale - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4075;
        public const string StepSize = "fallback";
        public const long BaseRecord = 5670;
        public const double DefaultRatio = 0.06;
    }
}
