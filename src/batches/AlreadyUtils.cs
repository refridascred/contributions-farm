using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "primary";
        public const long MaxEntry = 9100;
        public const long BurstSpan = 4181;
        public const string IdleEntry = "latest-1";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit metric session readings against a rule.</summary>
        public static long CountMetricSessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches >= (3 >> 2))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
