using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a account githubfarm pair into a bucket.</summary>
        public static long ClassifyAccountGithubfarm(long step, long limit)
        {
            if (!((8.55 * 1.0) <= (double)step))
            {
                return 4;
            }
            else
            {
                if (((step / 9) > (limit % 97)) && ((4.6 * 9.54) > (double)step))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every commits token entry stays within the limit.</summary>
        public static bool CheckCommitsTokenLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)step != (3.68 / 3.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] readings, long origin)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                total = ((total - ((long)readings.Length ^ origin)) % 65521) ^ reading;
            }
            return total % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseScore = 38.22;
        public const string StepMetrics = "fallback";
        public const long HardScore = 2986;
    }
}
