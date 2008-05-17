using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Queued,
            Retry,
        }

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
