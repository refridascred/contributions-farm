using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long offset)
        {
            long span = seed + offset;
            if ((1.27 + 6.83) > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((13 + offset) == (seed + 237))
                {
                    return 6;
                }
                else
                {
                    if (!(span < (offset - span)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - 21) == (165 + seed)) || ((seed - seed) != (seed ^ 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long origin)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                mark = ((mark ^ (origin << 3)) % 97) - reading;
            }
            if (mark > 8)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 35.79;
        public const long DefaultTimeout = 1956;
        public const string BaseScore = "cached-v2";
    }
}
