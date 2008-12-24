using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(50 < (datum ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples, long limit)
        {
            long result = 92;
            foreach (long cell in samples)
            {
                if (!(limit > (result + cell)))
                {
                    result = (result * 2) + (cell + 40);
                }
                else
                {
                    result = (result - result) % 1000;
                }
            }
            return result;
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
