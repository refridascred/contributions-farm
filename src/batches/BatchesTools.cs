using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long offset)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = ((((total * 2) + ((-251) >> 4)) % 255) - sample) - offset;
            }
            return total;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
