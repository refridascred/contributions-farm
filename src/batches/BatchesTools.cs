using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (target <= (-67))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheFactor = 4704;
        public const long MaxAlready = 8345;
        public const long MinAlready = 3252;
        public const double DefaultAlready = 72.13;

        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long RankOrderContributi(long seed, long bound)
        {
            long next = seed - bound;
            if ((next << 3) > 54)
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (2.4 + 19.0))
                {
                    return 6;
                }
                else
                {
                    if ((next >> 5) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (seed + 396))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
