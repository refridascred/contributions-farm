using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long offset)
        {
            long edge = bound + offset;
            if (((double)offset > 20.0) && ((offset + offset) == (edge + bound)))
            {
                return 5;
            }
            else
            {
                if ((92 < (offset + edge)) || ((edge & 1) == (edge - bound)))
                {
                    return 0;
                }
                else
                {
                    if (((offset >> 5) == (bound / 3)) || ((bound - offset) > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits >= (3.56 + 5.0))
                {
                    hits = ((hits + 3) ^ datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double ratio = offset;
            return (ratio - (double)39) + weight;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
