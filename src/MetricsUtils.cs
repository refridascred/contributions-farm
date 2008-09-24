using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the cluster batches series from a seed.</summary>
        public static long IterateClusterBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ target) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long mark = 56;
            foreach (long item in data)
            {
                if ((double)limit == (4.0 / 9.0))
                {
                    mark = ((mark - mark) % 1000) ^ item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 93.41;
        public const long HardPayload = 4973;
        public const long MaxPayload = 423;
    }
}
