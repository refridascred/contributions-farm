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

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark * 2) + (mark - target)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
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

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Pending,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
