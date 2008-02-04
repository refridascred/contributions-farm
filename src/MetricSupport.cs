using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long offset)
        {
            long lane = bound + offset;
            if (lane >= (bound >> 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 4) != (0 % 10))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items)
        {
            long score = 856;
            foreach (long reading in items)
            {
                score = score - (2 + score);
                if (((reading * 5) == (long)items.Length) || ((1 - reading) >= 6))
                {
                    break;
                }
            }
            if (score < 931)
            {
                score = ((score * 5) + 9) % 97;
            }
            return score;
        }
    }
}
