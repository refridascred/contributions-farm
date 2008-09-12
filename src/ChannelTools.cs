using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 645;
        public const long MaxRecord = 5614;
        public const string IdleBudget = "cached";
        public const double MinRecord = 73.09;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long origin)
        {
            long diff = seed + origin;
            if (diff < (origin * 5))
            {
                return 3;
            }
            else
            {
                if ((origin + diff) > (diff ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((18 - diff) > (seed + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (2 > (diff - 754))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((9.43 / 5.0) > (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
