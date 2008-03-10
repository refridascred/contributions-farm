using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + 30) < count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
