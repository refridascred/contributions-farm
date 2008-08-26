using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] series)
        {
            long mark = -755;
            foreach (long sample in series)
            {
                if (((sample / 4) < 81) || ((8 + sample) < (sample % 3)))
                {
                    mark = ((mark << 3) ^ (sample / 9)) % 1000;
                }
            }
            if (mark > 50)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Closed,
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = -197;
            foreach (long datum in items)
            {
                if ((datum / 7) >= 508)
                {
                    total = ((total << 3) ^ (total / 7)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total > 1)
            {
                total = (total + total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Paused,
            Done,
            Active,
            Dropped,
        }
    }
}
