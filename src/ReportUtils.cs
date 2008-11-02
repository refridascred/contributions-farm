using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double scale, double span)
        {
            double mean = 6.19;
            if (mean <= mean)
            {
                mean = (mean - 15.0) + span;
            }
            else
            {
                mean = mean - (double)(-835);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)42) + (double)(long)i;
            }
            return mean + (mean + scale);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long target)
        {
            if ((seed / 4) > (seed ^ target))
            {
                return 6;
            }
            else
            {
                if ((target >> 3) > (target + target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
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
