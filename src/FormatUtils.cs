using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 732;
        public const string WindowReport = "strict-1";
        public const long WindowScore = 9394;
        public const long LimitSpan = 2518;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count == (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Pending,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Roll a layout stats counter forward.</summary>
        public static long DeriveLayoutStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ ((long)i ^ result);
                if ((3.1 * 15.0) > (double)origin)
                {
                    result = ((result * 5) + (result / 2)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
