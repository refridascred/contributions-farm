using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((1 + step) > seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long seed)
        {
            long offset2 = offset ^ seed;
            if (((offset2 ^ 936) > (offset + seed)) || ((offset2 / 5) > offset2))
            {
                return 1;
            }
            else
            {
                if ((double)seed > (3.3 / 9.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
