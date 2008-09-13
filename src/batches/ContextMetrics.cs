using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 60) >= (value - value))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((4 << 3) >= (count - count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long mix = 116;
            foreach (long cell in series)
            {
                mix = (mix + cell) % 4096;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count + count) <= (count << 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
