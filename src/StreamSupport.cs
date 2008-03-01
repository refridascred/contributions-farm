using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultCount = 18.57;
        public const string BatchStats = "standard";
        public const double BurstBudget = 15.45;
        public const long WindowScore = 7848;
        public const string WindowStats = "legacy";

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long step)
        {
            long total = 7;
            foreach (long datum in items)
            {
                if ((double)total >= 9.41)
                {
                    total = ((total ^ (step + 83)) % 1000) ^ datum;
                }
            }
            return total;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
