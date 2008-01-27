using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account channel readings.</summary>
        public static long TotalAccountChannel(long[] items, long offset)
        {
            long score = 15;
            foreach (long reading in items)
            {
                if (!(offset >= (score * 4)))
                {
                    score = (score ^ reading) % 1000;
                }
                else
                {
                    score = (score - (reading + reading)) % 65521;
                }
            }
            if (score < (-54))
            {
                score = ((score << 2) ^ (offset % 2)) % 4096;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
