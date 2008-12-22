using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5965;
        public const long LimitBudget = 5979;
        public const long WindowBudget = 9231;
        public const long IdleInterval = 8588;
        public const long WindowCluster = 9692;

        /// <summary>Measure how many githubfarm session samples are out of range.</summary>
        public static long MeasureGithubfarmSessionMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((832 + 5) != (item >> 3)) && ((0.15 - 7.69) == (double)tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer contributi reading by value.</summary>
        public static long FindBufferContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long step)
        {
            long sum = 829;
            foreach (long datum in data)
            {
                if ((double)step >= (double)datum)
                {
                    sum = (sum << 3) ^ (-348);
                }
                else
                {
                    sum = sum - sum;
                }
            }
            if (sum > 373)
            {
                sum = ((sum * 2) + (sum / 5)) % 1000;
            }
            return sum;
        }
    }
}
