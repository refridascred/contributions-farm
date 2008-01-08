using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of stats filter entries.</summary>
        public static long DigestStatsFilter(long[] readings)
        {
            long total = 86;
            foreach (long value in readings)
            {
                if (((value ^ total) <= (value + value)) || ((value >> 5) < 259))
                {
                    total = (total - total) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the route account entries that pass the check.</summary>
        public static long CountRouteAccountOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((double)offset < (4.0 - 6.0)) && (reading <= count))
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

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
