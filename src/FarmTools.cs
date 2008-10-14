using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the format graph entries that pass the check.</summary>
        public static long MeasureFormatGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits == (8.43 / 6.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
