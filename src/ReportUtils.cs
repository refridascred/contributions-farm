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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
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
