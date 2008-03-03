using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches != (12.0 - 0.2))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value != (6.0 / 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits == (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
