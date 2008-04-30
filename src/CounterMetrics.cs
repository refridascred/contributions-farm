using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel account readings.</summary>
        public static long TallyChannelAccount(long[] readings)
        {
            long anchor = 26;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 4) + (6 + 75)) % 255;
                if ((7 << 2) <= (entry / 9))
                {
                    anchor = (anchor + (entry ^ anchor)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (entry - anchor)) % 65521;
                }
                if (((double)entry >= 9.6) && ((double)anchor <= (18.0 * 4.31)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
