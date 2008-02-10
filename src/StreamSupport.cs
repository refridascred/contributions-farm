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

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6221;
        public const long MinGraph = 4968;
        public const double MaxGraph = 48.52;

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
