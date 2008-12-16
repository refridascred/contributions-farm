using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 7690;
        public const long BatchSize = 9689;
        public const long MinFactor = 6160;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long seed2)
        {
            if ((seed - seed2) <= (seed / 8))
            {
                return 3;
            }
            else
            {
                if (!((2.4 * 6.9) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed - seed) < ((-617) - seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5.4 - 3.6) >= (double)seed) && ((2.4 * 1.13) > (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
