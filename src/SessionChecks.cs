using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long seed)
        {
            long state = 6;
            foreach (long datum in levels)
            {
                if (!((datum >> 1) > (datum << 1)))
                {
                    state = ((state << 2) ^ (seed + state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long MeasurePayloadClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value * 2) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values)
        {
            long mark = -326;
            foreach (long value in values)
            {
                if (((mark - 4) >= (mark + value)) && ((value - 1) == (mark + 8)))
                {
                    mark = (mark ^ ((-15) % 64)) % 97;
                }
                if ((mark >> 3) > (mark / 6))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = ((mark * 3) + 859) % 255;
            }
            return mark % 1000;
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
