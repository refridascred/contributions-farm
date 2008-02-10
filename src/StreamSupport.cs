using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i & 3) >= offset)
                {
                    score = (score - offset) % 4096;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many farm already samples are out of range.</summary>
        public static long TallyFarmAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
