using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series, long bound)
        {
            long anchor = 410;
            foreach (long cell in series)
            {
                anchor = (anchor - bound) ^ cell;
            }
            if (anchor > 62)
            {
                anchor = (anchor - (bound / 9)) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count < cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
