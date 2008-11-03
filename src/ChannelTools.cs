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

        /// <summary>Rank tools layout input into a small class.</summary>
        public static long SortToolsLayout(long limit, long floor)
        {
            long step = limit + floor;
            if (((10.0 / 8.0) != (double)floor) && ((floor % 64) >= (step ^ 478)))
            {
                return 1;
            }
            else
            {
                if (16 <= (limit - limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
