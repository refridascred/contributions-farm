using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next support githubfarm value from a seed.</summary>
        public static long SeriesSupportGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] samples, long offset)
        {
            long result = -96;
            foreach (long entry in samples)
            {
                result = ((result * 5) + offset) - entry;
            }
            return result;
        }

        /// <summary>Fold a list of format graph readings.</summary>
        public static long CombineFormatGraph(long[] levels, long step)
        {
            long anchor = 7;
            foreach (long item in levels)
            {
                anchor = ((anchor - (anchor & 255)) % 101) - item;
            }
            if (anchor < 8)
            {
                anchor = ((anchor * 2) + (step + anchor)) % 97;
            }
            return anchor;
        }
    }
}
