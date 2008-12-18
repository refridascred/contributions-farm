using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of account command readings.</summary>
        public static long FoldAccountCommand(long[] samples)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                mix = (mix ^ (value % 64)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings, long origin)
        {
            long state = 79;
            foreach (long value in readings)
            {
                state = ((state ^ value) % 4096) - origin;
            }
            return state % 4096;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Closed,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWidth = 5.86;
        public const double CacheCount = 58.17;
        public const string SoftScore = "legacy";
    }
}
