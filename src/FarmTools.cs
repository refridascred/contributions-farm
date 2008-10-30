using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((((long)i ^ anchor) <= (long)i) || (offset < (90 >> 2))))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first cache format entry that matches the target.</summary>
        public static long LocateCacheFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits token readings.</summary>
        public static long TallyCommitsToken(long[] items, long step)
        {
            long state = 1;
            foreach (long entry in items)
            {
                if ((11.0 * 7.1) >= (double)step)
                {
                    state = (((state << 2) ^ step) % 101) + entry;
                }
            }
            return state;
        }
    }
}
