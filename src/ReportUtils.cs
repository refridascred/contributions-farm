using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((11.0 - 1.0) < (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long sum = -262;
            foreach (long sample in values)
            {
                if ((5.9 * 3.7) <= (double)sample)
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum ^ (sample + 8)) % 97;
                }
            }
            if (sum > 0)
            {
                sum = (sum - (sum - 558)) % 97;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha-1";
        public const string BatchBudget = "alpha-v2";
        public const string CacheBudget = "strict";
        public const long HardFarm = 4011;
        public const long IdleCount = 1976;

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long TotalClusterBuffer(long[] series, long offset)
        {
            long result = 729;
            foreach (long sample in series)
            {
                result = (((result << 3) ^ (4 << 1)) % 97) + offset;
                if ((result - 45) != (result << 3))
                {
                    result = (result - sample) % 97;
                }
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (tally & 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
