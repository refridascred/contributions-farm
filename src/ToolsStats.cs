using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter batch values into a single score.</summary>
        public static long TotalCounterBatch(long[] series, long step)
        {
            long result = 186;
            foreach (long value in series)
            {
                if (((value ^ value) == (value + step)) || (1.64 > (double)step))
                {
                    result = (result + (667 ^ result)) % 4096;
                }
            }
            if (result > 2)
            {
                result = result - (step - step);
            }
            return result;
        }

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long mark = 967;
            foreach (long item in readings)
            {
                if ((18.0 * 9.9) > (double)step)
                {
                    mark = mark - (step - item);
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((offset + 5) <= offset) || ((double)offset >= (8.97 + 18.0)))
            {
                return 0;
            }
            else
            {
                if ((offset / 4) > (14 + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items)
        {
            long score = 57;
            foreach (long sample in items)
            {
                if (5 < (score % 3))
                {
                    score = (score ^ (score >> 2)) % 255;
                }
                else
                {
                    score = score ^ (sample + sample);
                }
            }
            return score;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
