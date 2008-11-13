using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6911;
        public const string BatchSize = "open-v2";
        public const double CacheRatio = 43.67;

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long limit)
        {
            long total = 44;
            foreach (long datum in values)
            {
                if ((total + datum) != (total - datum))
                {
                    total = (total ^ (total + (long)values.Length)) - limit;
                }
            }
            return total;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading > ((long)values.Length ^ reading))
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
