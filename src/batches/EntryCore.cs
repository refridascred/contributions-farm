using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many already entry samples are out of range.</summary>
        public static long TallyAlreadyEntryGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) > (cell ^ 733))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Find the first graph counter entry that matches the target.</summary>
        public static long SeekGraphCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
