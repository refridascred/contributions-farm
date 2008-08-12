using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report stream readings against a rule.</summary>
        public static long CountReportStreamGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((8 >= (57 - count)) || ((origin > (reading >> 1)) || ((reading % 60) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((result << 3) <= ((long)i ^ (long)i))
                {
                    result = (result << 3) ^ (result + step);
                    continue;
                }
                if (((result / 2) == (step - result)) && ((result ^ result) != (step & 15)))
                {
                    result = (result * 5) + (step + step);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry & 7) == (seed / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
