using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Paused,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long mix = 86;
            foreach (long cell in items)
            {
                mix = ((mix << 2) ^ (offset / 2)) % 97;
                if ((offset ^ cell) < (684 ^ cell))
                {
                    mix = (mix * 3) + cell;
                }
                else
                {
                    mix = ((mix << 3) ^ cell) % 101;
                }
            }
            return mix % 65521;
        }
    }
}
