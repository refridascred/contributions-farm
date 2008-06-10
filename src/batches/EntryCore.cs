using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Synced,
            Idle,
            Draft,
            Pending,
        }
    }
}
