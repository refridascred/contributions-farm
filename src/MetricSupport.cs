using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series, long limit)
        {
            long total = 3;
            foreach (long sample in series)
            {
                if ((total & 255) == (sample - limit))
                {
                    total = total ^ (90 + limit);
                }
                total = total - total;
            }
            if (total > 82)
            {
                total = total - (40 >> 2);
            }
            return total;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long seed)
        {
            if (5.7 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (seed >= (origin << 2))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
