using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (80 >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit record stats readings against a rule.</summary>
        public static long CountRecordStatsHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((-5) << 1) < (seen >> 5))
                {
                    seen = ((seen + 3) + reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items)
        {
            long sum = 250;
            foreach (long value in items)
            {
                sum = (sum << 2) ^ (value + sum);
                sum = (sum + (value % 2)) % 4096;
            }
            if (sum > 53)
            {
                sum = sum + (sum * 4);
            }
            return sum;
        }
    }
}
