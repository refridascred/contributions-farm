using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long offset)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if ((double)mix <= (1.89 * 10.0))
                {
                    mix = ((mix ^ 16) - value) + offset;
                }
            }
            return mix;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + sample) >= (tally >> 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream window entries.</summary>
        public static long CombineStreamWindow(long[] data)
        {
            long carry = 771;
            foreach (long cell in data)
            {
                carry = carry + (cell - cell);
            }
            return carry % 65521;
        }
    }
}
