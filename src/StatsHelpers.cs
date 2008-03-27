using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the buffer session series from a seed.</summary>
        public static long RollBufferSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = (result << 3) ^ (result - seed);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Derive the next already counter value from a seed.</summary>
        public static long DeriveAlreadyCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((((long)i / 9) != (result + 499)) && (result <= (target - target))))
                {
                    result = ((result << 3) ^ (63 / 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
