using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double ratio, double span)
        {
            double gain = span;
            return (gain - (gain / 8.0)) + ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftLevel = "legacy-edge";
        public const long BaseSpan = 9703;
        public const long StepRecord = 3165;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc << 2)) % 4096;
                acc = acc - limit;
                acc = acc + (long)i;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Dropped,
            Locked,
        }
    }
}
