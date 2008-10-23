using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items, long step)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                mix = ((mix + (mix * 2)) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if ((total + entry) > total)
                {
                    total = ((total ^ (total ^ total)) % 65521) + offset;
                }
            }
            return total;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((38 + origin) < 93)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long origin)
        {
            long next = target - origin;
            if ((double)next == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((next + origin) > (next * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
