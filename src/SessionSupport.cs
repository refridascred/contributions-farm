using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a stats tools sample.</summary>
        public static long LookupStatsToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
