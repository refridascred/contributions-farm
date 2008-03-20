using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstTimeout = 27.11;
        public const double WindowBudget = 5.44;
        public const string BatchSize = "standard-1";
        public const double MaxDepth = 49.32;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long step2)
        {
            if ((791 >= (step - step)) && ((27 % 2) <= (step2 >> 5)))
            {
                return 8;
            }
            else
            {
                if (((double)step2 <= (17.0 + 6.0)) || (step > (step2 << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((step2 & 63) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + step2) >= step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((seed * 5) >= (447 + item))
                {
                    acc = acc + (acc + acc);
                }
                else
                {
                    acc = (acc + (-431)) % 101;
                }
            }
            if (acc > 59)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 97;
        }
    }
}
