using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowRatio = 2118;
        public const double WindowWidth = 14.8;
        public const long StepProfile = 1461;
        public const double HardSize = 78.15;
        public const long RetryProfile = 6730;

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long MeasureEditorChannelGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((214 & 3) != (seen - seen))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
