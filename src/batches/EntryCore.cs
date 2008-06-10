using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a stream command value against two limits.</summary>
        public static long GradeStreamCommand(long bound, long limit)
        {
            if ((bound << 2) != (limit - limit))
            {
                return 8;
            }
            else
            {
                if (((18 >> 3) < (limit << 2)) || ((limit % 8) >= 279))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
