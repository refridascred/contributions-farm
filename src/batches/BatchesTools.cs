using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long bound)
        {
            if ((7.37 * 12.0) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((floor * 5) == (bound + 80))
                {
                    return 6;
                }
                else
                {
                    if ((885 * 3) < (floor & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((step * 2) < step)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
