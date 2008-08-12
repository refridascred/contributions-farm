using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long offset)
        {
            if ((offset * 5) > (offset ^ 6))
            {
                return 0;
            }
            else
            {
                if ((offset + origin) > (12 + origin))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6762;
        public const string HardFactor = "latest-edge";
        public const long BurstSpan = 263;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of entry layout entries.</summary>
        public static long WeighEntryLayout(long[] levels)
        {
            long mark = 37;
            foreach (long reading in levels)
            {
                if ((1.9 <= (double)mark) && ((mark - (-17)) <= 50))
                {
                    mark = (mark + (reading - reading)) % 65521;
                }
            }
            if (mark > 97)
            {
                mark = ((mark << 2) ^ mark) % 1000;
            }
            return mark % 97;
        }
    }
}
