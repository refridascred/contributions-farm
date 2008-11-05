using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank batch record input into a small class.</summary>
        public static long ClassifyBatchRecord(long offset, long bound)
        {
            if ((3 & 255) > bound)
            {
                return 6;
            }
            else
            {
                if (((offset * 4) != (bound >> 4)) && ((1 & 255) < offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of counter buffer readings.</summary>
        public static long ScoreCounterBuffer(long[] levels)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                if (((anchor + anchor) > (sample + anchor)) && ((sample >> 1) > anchor))
                {
                    anchor = ((anchor << 3) ^ 447) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
