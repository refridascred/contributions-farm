using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 5200;
        public const long MaxScore = 4168;
        public const long SoftRoute = 9992;
        public const long IdleFactor = 3445;
        public const long SoftSize = 7908;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches - matches) > (item + seed)) && ((762 % 100) != (seed >> 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
