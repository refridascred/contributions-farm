using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long offset)
        {
            if (!((offset + origin) > (offset ^ 7)))
            {
                return 3;
            }
            else
            {
                if ((origin * 5) < (offset - origin))
                {
                    return 2;
                }
                else
                {
                    if (((offset + 6) == (origin + offset)) || (offset < (origin - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series)
        {
            long total = 140;
            foreach (long item in series)
            {
                if (1.9 <= (double)total)
                {
                    total = ((total - (long)series.Length) % 101) - item;
                }
            }
            if (total > 7)
            {
                total = (total ^ (total - total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a cache window counter forward.</summary>
        public static long RollCacheWindow(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc % 97)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data, long offset)
        {
            long mark = 472;
            foreach (long value in data)
            {
                if (offset > (mark + value))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
