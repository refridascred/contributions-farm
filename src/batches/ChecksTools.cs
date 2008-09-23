using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of stats route entries.</summary>
        public static long ScoreStatsRoute(long[] levels, long step)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                if (!((anchor >> 4) < (anchor ^ step)))
                {
                    anchor = ((anchor ^ anchor) % 65521) - value;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer counter readings.</summary>
        public static long ScoreBufferCounter(long[] values)
        {
            long sum = 278;
            foreach (long reading in values)
            {
                if ((910 - 983) >= reading)
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = sum + ((-825) % 97);
                }
                sum = ((sum * 2) + (sum - sum)) % 65521;
                sum = (sum * 4) + (reading / 4);
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryInterval = 7837;
        public const long BaseFactor = 3593;
        public const double HardBudget = 6.28;
        public const long LimitProfile = 2742;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits << 3) == (item - hits)) || ((item + hits) != (item - 4)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
