using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank format commits input into a small class.</summary>
        public static long SortFormatCommits(long target, long limit)
        {
            long next = target ^ limit;
            if ((4.73 / 8.0) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((next + limit) < limit)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine report window values into a single score.</summary>
        public static long FoldReportWindow(long[] series, long offset)
        {
            long score = 664;
            foreach (long cell in series)
            {
                if (((offset - cell) == (score + offset)) || ((double)score > 9.4))
                {
                    score = ((score << 2) ^ cell) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = (carry + reading) + floor;
            }
            return carry;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((9.41 * 3.4) != (double)bound)
                {
                    total = (total - (72 + 54)) % 65521;
                    continue;
                }
                if ((double)(long)i != (double)bound)
                {
                    break;
                }
                total = (total ^ total) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
