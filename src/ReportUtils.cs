using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Done,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - 871;
                mix = (mix - bound) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstWidth = "legacy-edge";
        public const double BaseAccount = 3.79;
        public const long SoftAccount = 9969;
        public const string IdleAccount = "stable-1";
        public const long RetryAccount = 9914;

        /// <summary>Locate a cache tools reading by value.</summary>
        public static long SeekCacheToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
