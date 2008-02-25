using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every stats metric entry stays within the limit.</summary>
        public static bool ValidateStatsMetricLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long ScoreBatchesContext(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (item << 1)) % 65521;
                    total = (total << 2) ^ ((long)i ^ item);
                }
                if (total > item)
                {
                    total = ((total * 2) + (total * 2)) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
