using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long seed)
        {
            if (target <= (target * 4))
            {
                return 6;
            }
            else
            {
                if ((seed - seed) >= (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 2) != (target / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((41 & 31) < (target + 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (origin & 31))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                anchor = (((anchor << 2) ^ (anchor + datum)) % 255) + seed;
            }
            return anchor;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSize = 1480;
        public const long RetryProfile = 3393;
        public const long BaseBudget = 6035;
        public const long RetryLevel = 2259;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
