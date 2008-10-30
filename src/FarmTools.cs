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

        /// <summary>Match up graph checks samples.</summary>
        public static long MatchGraphChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
