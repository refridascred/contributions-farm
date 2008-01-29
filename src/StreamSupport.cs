using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the editor profile entries that pass the check.</summary>
        public static long MeasureEditorProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen - entry) > entry) || (seen < (entry + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
