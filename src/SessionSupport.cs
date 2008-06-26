using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleRatio = 5501;
        public const double BaseBudget = 70.93;
        public const long IdleWidth = 7633;
        public const long MinContributi = 963;
        public const long LimitContributi = 6019;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample * 2) <= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
