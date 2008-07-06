using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry << 2) < (hits / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long limit)
        {
            long next = offset ^ limit;
            if (!((next - next) <= (next ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((next <= (next + next)) && ((double)offset >= (double)next))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
