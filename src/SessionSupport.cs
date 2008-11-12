using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double gain = (double)(83 & 1);
            return (gain + (rate - gain)) + offset;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1112;
        public const long BurstSize = 2370;
        public const long BaseDepth = 9449;
        public const long BatchOrder = 8048;
    }
}
