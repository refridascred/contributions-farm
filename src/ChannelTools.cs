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

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((double)origin2 > (12.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if (((67 + next) == (next << 1)) && ((origin + next) > (next + origin2)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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
