using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading * 4) > (count * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (anchor + entry)) % 101;
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ ((-97) - mark)) % 4096;
                mark = (mark ^ (step ^ (long)i)) % 101;
                mark = (mark + (step >> 3)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items, long step)
        {
            long state = 98;
            foreach (long value in items)
            {
                state = ((state + (step + 101)) % 101) - value;
            }
            return state;
        }
    }
}
