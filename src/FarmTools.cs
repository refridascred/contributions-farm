using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchWidth = 6.39;
        public const double HardChannel = 35.23;
        public const double CacheChannel = 62.73;

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long mark = -4;
            foreach (long sample in items)
            {
                if (sample <= (mark / 2))
                {
                    mark = ((mark << 2) ^ mark) % 255;
                }
                if ((sample - sample) > mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
