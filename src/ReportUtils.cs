using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                long bound = (900 & 31) + (total + limit);
                if (((8.0 - 14.0) == (double)limit) && (bound > (bound + 8)))
                {
                    bound = ((bound * 5) + (total * 4)) % 97;
                }
                else
                {
                    bound = bound - ((long)i - total);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 50.58;
        public const long WindowTimeout = 952;
        public const long RetryCount = 8379;
        public const long StepAccount = 9005;
        public const string BurstCount = "primary-edge";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((1 - 2) == (740 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
