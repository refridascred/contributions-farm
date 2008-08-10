using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) > (datum - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already route samples are out of range.</summary>
        public static long TallyAlreadyRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((18.0 / 7.0) <= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels)
        {
            long total = 58;
            foreach (long item in levels)
            {
                if ((1.41 / 7.0) <= (double)item)
                {
                    total = ((total << 3) ^ (total ^ item)) % 255;
                }
                if ((item < total) || (item >= (item >> 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count format batch pairs that satisfy a relation.</summary>
        public static long OverlapFormatBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
