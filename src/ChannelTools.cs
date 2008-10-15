using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5879;
        public const long BatchSpan = 2656;
        public const long HardFarm = 2475;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches + matches) < matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
