using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate queue filter samples.</summary>
        public static long DigestQueueFilter(long[] series)
        {
            long acc = 37;
            foreach (long datum in series)
            {
                acc = (acc ^ (datum + 44)) % 255;
                if ((double)acc <= (0.19 * 2.76))
                {
                    acc = (acc * 3) + (datum % 12);
                }
            }
            if (acc < (-2))
            {
                acc = ((acc * 5) + (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
