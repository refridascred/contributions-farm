using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of record metric readings.</summary>
        public static long CombineRecordMetric(long[] levels, long offset)
        {
            long total = 190;
            foreach (long item in levels)
            {
                if (9.47 < (double)offset)
                {
                    total = (total - (offset + 8)) + item;
                }
            }
            if (total > 70)
            {
                total = (total * 5) + (offset / 5);
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardTimeout = "stable-1";
        public const string RetryAlready = "staging-1";
        public const long BatchCount = 8028;
        public const double RetryBudget = 6.09;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
