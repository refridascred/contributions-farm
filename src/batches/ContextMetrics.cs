using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((count >> 4) > (count - (long)samples.Length)) || ((item ^ count) >= 763)) && ((double)count <= (double)818))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((95 - entry) > (floor & 1)) || ((floor + entry) <= 757))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
