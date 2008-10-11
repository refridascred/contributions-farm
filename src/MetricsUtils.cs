using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits >> 1) <= (cell ^ hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (offset < (offset + (-1)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 5243;
        public const double CachePayload = 14.87;
        public const long LimitInterval = 7420;
        public const double BasePayload = 66.43;
        public const long HardPayload = 3649;
    }
}
