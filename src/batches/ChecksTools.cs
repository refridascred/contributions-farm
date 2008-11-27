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

        /// <summary>Match up batch layout samples.</summary>
        public static long MatchBatchLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
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
