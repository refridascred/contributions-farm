using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string RetryCount = "legacy";
        public const long StepSupport = 5230;
        public const long LimitSupport = 1719;
        public const long StepLevel = 9425;

        /// <summary>Adjust a order schema reading.</summary>
        public static double ProjectOrderSchema(double weight, double offset)
        {
            double gain = 9.72;
            if (gain >= 17.0)
            {
                gain = ((gain + (double)(-401)) - weight) + offset;
            }
            else
            {
                gain = gain + 7.0;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (3.48 / 3.0);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up metric notes samples.</summary>
        public static long PairMetricNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long GradeCacheAccount(long offset, long step)
        {
            if (step <= (67 + 389))
            {
                return 3;
            }
            else
            {
                if (((offset / 4) != (step + step)) && ((4.0 * 9.0) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
