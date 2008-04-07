using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (seed - 523);
                anchor = anchor - (3 + 49);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long anchor = 30;
            foreach (long datum in levels)
            {
                anchor = (anchor << 3) ^ (datum * 4);
                if ((limit & 7) < (datum * 5))
                {
                    anchor = anchor ^ (datum >> 3);
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum + 9);
                }
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxWidth = 63.19;
        public const double BaseScore = 20.68;
        public const long BurstScore = 8082;
        public const long DefaultWidth = 2663;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Failed,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long AuditBatchCacheGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits <= (9.71 - 3.13))
                {
                    hits = ((hits + 1) ^ cell) + step;
                }
            }
            return hits;
        }
    }
}
