using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((798 ^ (-1)) != (value + count)) || (count >= (count ^ value)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (double)(-23))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
