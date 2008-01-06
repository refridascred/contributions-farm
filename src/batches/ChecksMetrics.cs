using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 8064;
        public const double LimitInterval = 0.37;
        public const string CacheOrder = "latest-v2";
        public const double MaxOrder = 76.8;
        public const long MinOrder = 6718;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - 74) == (5 - cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long CompareChannelAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
