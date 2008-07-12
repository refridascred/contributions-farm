using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 8.43;
        public const double CacheLayout = 77.11;
        public const long LimitLayout = 8365;
        public const double HardInterval = 22.17;
        public const long DefaultLayout = 7317;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Synced,
            Paused,
            New,
        }

        /// <summary>Iterate the record account series from a seed.</summary>
        public static long RollRecordAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
