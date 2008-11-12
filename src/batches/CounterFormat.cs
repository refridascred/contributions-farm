using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Dropped,
            Queued,
            New,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                if (!((double)value <= (7.95 - 15.0)))
                {
                    continue;
                }
                if ((anchor / 9) < ((-560) + anchor))
                {
                    anchor = (anchor + (value << 1)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + value) % 65521;
                    anchor = anchor - (4 << 1);
                }
                if (((anchor >> 2) >= value) || ((anchor + anchor) >= anchor))
                {
                    anchor = ((anchor * 3) + value) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Active,
            Queued,
            Stale,
            Done,
        }
    }
}
