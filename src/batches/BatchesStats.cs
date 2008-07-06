using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the buffer stats entries that pass the check.</summary>
        public static long MeasureBufferStatsHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item / 4) > tally)
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels, long seed)
        {
            long state = 75;
            foreach (long value in levels)
            {
                state = ((((state << 3) ^ (state / 9)) % 4096) + value) + seed;
            }
            return state;
        }
    }
}
