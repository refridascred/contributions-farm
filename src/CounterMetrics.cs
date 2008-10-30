using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long AuditBufferQueueOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - (long)levels.Length) < (matches / 5))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((origin - origin) >= cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "latest-v2";
        public const double LimitQueue = 91.56;
        public const long WindowQueue = 8146;
        public const long SoftQueue = 473;
    }
}
