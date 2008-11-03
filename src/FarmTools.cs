using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm checks pair into a bucket.</summary>
        public static long BucketGithubfarmChecks(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (!(floor < edge))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor & 15))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
