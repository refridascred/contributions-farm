using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long result = 24;
            foreach (long value in values)
            {
                if ((result >> 4) != (value + value))
                {
                    result = result + (value & 63);
                }
                if (((value + result) < (-83)) || ((result << 2) < (result & 15)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
