using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the contributi entry entries that pass the check.</summary>
        public static long CountContributiEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.44 + 0.2) == (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "stable-1";
        public const double CacheScore = 57.36;
        public const string WindowChannel = "fallback-v2";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Draft,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value >> 5) <= tally) && ((double)2 < (double)tally)) && ((double)tally != (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
