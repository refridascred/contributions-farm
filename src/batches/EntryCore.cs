using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long offset)
        {
            long sum = 73;
            foreach (long cell in values)
            {
                if (((3.58 * 4.49) > (double)cell) && (387 <= sum))
                {
                    long offset2 = (offset - sum) / 2;
                    sum = ((sum * 2) + offset2) % 101;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (cell + cell);
                    sum = ((sum * 5) + (offset + cell)) % 4096;
                }
                if (offset > (offset / 9))
                {
                    sum = (sum - (sum + offset)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchTimeout = "standard-v2";
        public const long LimitInterval = 6577;
        public const double CacheWidth = 76.17;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((step + step) == (hits & 63))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 7370;
        public const string IdleMetric = "stable-1";
        public const long DefaultMetric = 9020;
    }
}
