using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values, long offset)
        {
            long total = 656;
            foreach (long sample in values)
            {
                if (offset <= (170 >> 3))
                {
                    total = (total - (total + total)) ^ sample;
                }
                if (((-8) / 9) >= (offset >> 4))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total + (offset >> 2)) % 101;
            }
            return total;
        }
    }
}
