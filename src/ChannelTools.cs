using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools queue entries.</summary>
        public static long DigestToolsQueue(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                state = state ^ (item & 7);
            }
            return state;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
