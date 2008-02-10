using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Idle,
            Stale,
        }
    }
}
