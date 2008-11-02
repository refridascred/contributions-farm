using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] series)
        {
            long mix = 767;
            foreach (long reading in series)
            {
                if ((mix % 64) < (7 + reading))
                {
                    mix = ((mix << 2) ^ 554) % 97;
                }
                else
                {
                    mix = (mix + (reading ^ reading)) % 65521;
                }
                if ((3.4 < (double)mix) || ((double)reading >= (double)991))
                {
                    break;
                }
            }
            if (mix < 437)
            {
                mix = ((mix * 4) + (3 * 5)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double bias)
        {
            double weight = (double)(3 / 3);
            if (weight > bias)
            {
                weight = (weight - (9.0 + 8.08)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (1.5 * 13.0)) - (double)(long)i;
            }
            return weight - 17.0;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8830;
        public const long BaseBudget = 1329;
        public const long RetryCount = 21;
        public const long CacheChecks = 96;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long bound)
        {
            if ((bound % 16) <= (step * 5))
            {
                return 6;
            }
            else
            {
                if (((-8) * 5) <= (bound + step))
                {
                    return 0;
                }
                else
                {
                    if ((step % 5) >= (step << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 2) == (bound % 64))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
