using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mark = 622;
            foreach (long value in readings)
            {
                if ((mark + value) <= (mark - mark))
                {
                    mark = (mark + (97 + mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
