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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (offset <= 17)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
