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

        /// <summary>Count channel command pairs that satisfy a relation.</summary>
        public static long PairChannelCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
