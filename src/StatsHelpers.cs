using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 6.4)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 7280;
        public const double BatchToken = 37.96;
        public const long BaseToken = 4006;
        public const long HardRatio = 6116;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
