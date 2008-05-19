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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

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
