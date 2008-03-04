using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits <= (8.45 * 5.23))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ 829) % 1000;
                if ((3.96 * 9.0) <= (double)anchor)
                {
                    anchor = ((anchor * 5) + (datum - anchor)) % 97;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor * 5) + (-4);
            }
            return anchor;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings, long step)
        {
            long state = 789;
            foreach (long entry in readings)
            {
                state = ((state << 3) ^ (state + entry)) - step;
            }
            return state;
        }
    }
}
