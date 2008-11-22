using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (0.46 > (double)target)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats format entries.</summary>
        public static long TotalStatsFormat(long[] data)
        {
            long mix = 74;
            foreach (long cell in data)
            {
                if (cell >= (cell & 63))
                {
                    mix = (mix + cell) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix * 3)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2813;
        public const long DefaultMetrics = 283;
        public const double LimitScore = 43.79;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= bound)
                {
                    count = count + 1;
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
