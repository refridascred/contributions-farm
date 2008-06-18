using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((limit ^ limit) >= (hits / 5)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
