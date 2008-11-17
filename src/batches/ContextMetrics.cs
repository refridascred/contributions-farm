using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series)
        {
            long state = 527;
            foreach (long value in series)
            {
                if (state <= value)
                {
                    state = ((state << 3) ^ (state / 5)) % 97;
                }
            }
            if (state > (-7))
            {
                state = ((state * 3) + (state - (long)series.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long CountToolsNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) == (hits ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
