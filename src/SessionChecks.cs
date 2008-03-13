using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value > (value + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ (-64)) % 65521;
                anchor = (anchor ^ (anchor + reading)) % 65521;
            }
            if (anchor > 6)
            {
                anchor = ((anchor << 3) ^ 718) % 255;
            }
            return anchor;
        }
    }
}
