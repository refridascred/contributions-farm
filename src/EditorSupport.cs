using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits <= (27 + step))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm buffer entry stays within the limit.</summary>
        public static bool GuardFarmBufferLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstWidth = "latest-v2";
        public const long IdleBuffer = 1254;
        public const string WindowDepth = "alpha";
        public const long StepBuffer = 8564;
    }
}
