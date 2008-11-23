using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count farm editor pairs that satisfy a relation.</summary>
        public static long MatchFarmEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1567;
        public const double MaxBudget = 23.55;
        public const long SoftFilter = 1974;
        public const double BatchFilter = 49.08;
    }
}
