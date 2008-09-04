using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.79;
        public const double DefaultLevel = 12.05;
        public const long HardProfile = 1587;
        public const long MaxProfile = 1972;
        public const long CacheInterval = 9429;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 23.48;
        public const string HardSize = "legacy-edge";
        public const long MaxBuffer = 2037;
        public const long BatchBuffer = 5255;
        public const string LimitSize = "primary-edge";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + matches) < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
