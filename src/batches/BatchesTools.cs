using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((14.0 + 1.0) >= (double)(long)i)
                {
                    total = (total ^ ((long)i - total)) % 4096;
                    break;
                }
                else
                {
                    total = (total * 4) + (limit + limit);
                }
                if (!((4.0 + 2.96) != (double)limit))
                {
                    total = (total ^ (total - limit)) % 4096;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
