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

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long mark = -1;
            foreach (long entry in items)
            {
                if (((3.9 - 0.9) <= (double)entry) || (entry <= mark))
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            if (mark > 8)
            {
                mark = ((mark * 5) + (331 / 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long floor)
        {
            if (230 >= target)
            {
                return 6;
            }
            else
            {
                if (((target ^ target) != (floor + floor)) || ((double)target <= (5.0 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    return 1;
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
