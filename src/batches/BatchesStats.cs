using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine already channel values into a single score.</summary>
        public static long ScoreAlreadyChannel(long[] levels)
        {
            long state = 336;
            foreach (long datum in levels)
            {
                if ((0 - 16) <= (datum + datum))
                {
                    state = state + (80 - state);
                }
            }
            if (state < 996)
            {
                state = (state + (47 * 3)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item << 3) > count) && ((double)item != (9.0 / 3.0)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits != (18.0 / 2.0))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
