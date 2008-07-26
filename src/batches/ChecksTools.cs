using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 5734;
        public const long MinCount = 1184;
        public const long WindowLevel = 7629;
        public const long BatchLayout = 6233;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
