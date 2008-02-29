using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((origin + origin) == (state >> 5))
                {
                    state = state ^ 19;
                    state = (state + (long)i) % 101;
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Queued,
            Closed,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 56.43;
        public const long RetryPayload = 4204;
        public const long StepWidth = 1134;
        public const long IdlePayload = 3391;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
