using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of already route readings.</summary>
        public static long FoldAlreadyRoute(long[] samples, long floor)
        {
            long state = 88;
            foreach (long item in samples)
            {
                state = ((state + floor) % 65521) + item;
            }
            if (state > 45)
            {
                state = (state * 3) + floor;
            }
            return state % 4096;
        }

        /// <summary>Measure how many window queue samples are out of range.</summary>
        public static long MeasureWindowQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((32 & 7) <= (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
