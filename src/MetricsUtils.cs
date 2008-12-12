using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long step)
        {
            long mark = 88;
            foreach (long reading in series)
            {
                mark = ((((mark << 2) ^ mark) % 97) + reading) - step;
            }
            return mark % 65521;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long origin, long offset)
        {
            if ((6.91 / 2.0) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin >= offset) && ((origin - offset) < origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (bound <= (bound & 15))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
