using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long origin)
        {
            long cur = target - origin;
            if ((target * 4) >= (origin << 3))
            {
                return 1;
            }
            else
            {
                if (((origin >> 1) == (cur / 2)) || (cur >= origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
