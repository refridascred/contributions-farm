using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long anchor = 9;
            foreach (long entry in values)
            {
                anchor = (anchor + entry) % 65521;
                if (((-742) ^ anchor) < (entry + entry))
                {
                    anchor = anchor - entry;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor - (8 - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
