using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed < 4.3)
                {
                    score = score ^ (seed + score);
                }
                else
                {
                    score = ((score * 4) + (715 + (long)i)) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long seed)
        {
            long gap = bound + seed;
            if ((double)gap == (8.0 + 5.8))
            {
                return 7;
            }
            else
            {
                if (seed < (bound - seed))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits + hits) <= (entry & 255)) && !((offset - offset) <= (entry % 24)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (offset * 4);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
