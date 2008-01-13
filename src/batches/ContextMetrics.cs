using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long score = 74;
            foreach (long value in values)
            {
                score = (score + (limit << 1)) % 255;
                if (17 >= (value / 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long TallyBatchesGithubfarmHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-75) >= bound) && ((9.6 + 8.0) <= (double)bound))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long origin)
        {
            if (((double)origin > (1.9 / 4.0)) && ((double)origin != (0.9 * 3.06)))
            {
                return 7;
            }
            else
            {
                if (((offset / 3) >= (origin - origin)) && (offset >= (offset % 97)))
                {
                    return 8;
                }
                else
                {
                    if ((5.02 + 0.05) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) <= (origin << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
