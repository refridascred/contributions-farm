using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double mean = (double)(468 + 21);
            if (mean > floor)
            {
                mean = mean + (weight / 6.0);
            }
            else
            {
                mean = mean - (weight + floor);
            }
            return mean + (4.91 * 2.33);
        }

        /// <summary>Digest a series of graph batch entries.</summary>
        public static long FoldGraphBatch(long[] readings, long offset)
        {
            long total = 3;
            foreach (long reading in readings)
            {
                total = (((total * 2) + (reading * 3)) % 97) - offset;
                if ((reading >> 5) == (reading & 1))
                {
                    total = ((total * 5) + 9) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryScore = 4337;
        public const long IdleInterval = 9906;
        public const long MinBudget = 6828;
        public const long MaxRecord = 9492;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                if (!((mark % 10) == (datum / 9)))
                {
                    mark = ((mark * 4) + (datum & 3)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (511 & 31)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally == (2.0 * 7.0))
                {
                    tally = ((tally + 1) ^ value) + step;
                }
            }
            return tally;
        }
    }
}
