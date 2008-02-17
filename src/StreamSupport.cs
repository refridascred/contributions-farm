using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of counter token entries.</summary>
        public static long FoldCounterToken(long[] series)
        {
            long acc = 657;
            foreach (long entry in series)
            {
                acc = ((acc + (acc + acc)) % 65521) - entry;
            }
            return acc;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits account pair into a bucket.</summary>
        public static long RankCommitsAccount(long step, long offset)
        {
            if ((11.0 * 7.88) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (!(offset > (step - step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (8.0 * 4.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
