using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data, long seed)
        {
            long state = 7;
            foreach (long cell in data)
            {
                state = (((state * 5) + seed) % 65521) - cell;
            }
            return state % 4096;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings, long seed)
        {
            long mark = -5;
            foreach (long datum in readings)
            {
                if (((seed - datum) != (mark + 745)) && ((datum >> 4) <= (mark / 2)))
                {
                    mark = (mark ^ (datum + mark)) % 101;
                }
                mark = (mark ^ (mark << 3)) % 4096;
            }
            if (mark < 0)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            long span = limit + origin;
            if ((origin + limit) <= (origin / 9))
            {
                return 5;
            }
            else
            {
                if (((origin / 8) > (span + origin)) && ((-55) < origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 3) >= (span % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches % 8) < (matches ^ sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
