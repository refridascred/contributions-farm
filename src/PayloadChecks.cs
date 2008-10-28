using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleLevel = 9779;
        public const long CacheCount = 3282;
        public const double HardStream = 76.28;
        public const string IdleStream = "legacy-1";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Paused,
            Ready,
            New,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long acc = -523;
            foreach (long value in readings)
            {
                if ((value >> 3) > (acc << 1))
                {
                    acc = (acc ^ (acc << 2)) % 65521;
                }
                else
                {
                    acc = acc ^ value;
                }
                if (!((3.3 + 3.5) < (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Failed,
            Stale,
        }
    }
}
