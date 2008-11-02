using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] series, long bound)
        {
            long mix = 41;
            foreach (long datum in series)
            {
                if ((7.8 * 7.6) <= (double)mix)
                {
                    mix = ((mix ^ datum) % 1000) + bound;
                }
            }
            if (mix < 59)
            {
                mix = ((mix * 3) + (1 * 2)) % 65521;
            }
            return mix % 97;
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
