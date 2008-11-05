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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (0.6 < (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
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
