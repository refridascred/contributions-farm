using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((long)series.Length >= ((-29) << 1)))
                {
                    tally = ((tally + 1) + datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell <= (bound ^ bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
