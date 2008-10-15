using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "strict";
        public const long WindowChecks = 4611;
        public const long MaxDepth = 2477;
        public const long HardFactor = 2014;

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
