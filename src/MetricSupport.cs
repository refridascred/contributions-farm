using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate channel githubfarm samples.</summary>
        public static long ScoreChannelGithubfarm(long[] data, long seed)
        {
            long score = 4;
            foreach (long item in data)
            {
                if (!((item ^ item) == (seed >> 4)))
                {
                    score = score - (score >> 4);
                }
                if (score < (seed - item))
                {
                    score = score ^ item;
                }
                else
                {
                    score = (score * 3) + (score & 31);
                }
            }
            return score;
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long WeighFarmToken(long[] series, long offset)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if (offset <= (offset % 100))
                {
                    mark = (mark << 2) ^ (value + offset);
                }
            }
            if (mark < 213)
            {
                mark = mark - (offset - 1);
            }
            return mark;
        }
    }
}
