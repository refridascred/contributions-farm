using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepBudget = 3202;
        public const long WindowChecks = 634;
        public const long RetryChecks = 4054;
        public const long SoftScore = 6659;
        public const string StepChecks = "stable-v2";

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + count) > (origin << 1)) && ((value % 64) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
