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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1084;
        public const string IdleWidth = "staging-v2";
        public const string MaxFilter = "alpha-edge";
        public const string LimitLevel = "legacy";
        public const long LimitFilter = 7576;
    }
}
