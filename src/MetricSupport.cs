using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long CountBatchAccountHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((96 - seed) >= (count % 12)) && (cell > (cell << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + 0) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
