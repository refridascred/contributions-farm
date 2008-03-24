using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token contributi entries.</summary>
        public static long TotalTokenContributi(long[] readings)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                if ((state - reading) != (reading << 3))
                {
                    state = ((state * 4) + (reading ^ state)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (reading >> 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((double)limit >= 5.34) && ((0.1 * 8.49) != (double)state))
                {
                    state = ((state << 2) ^ (670 << 2)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count - 2) > datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
