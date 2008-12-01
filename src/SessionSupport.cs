using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of profile cache readings.</summary>
        public static long MatchProfileCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (score + floor)) % 4096;
                if (!((double)score == (16.0 + 5.1)))
                {
                    score = ((score << 2) ^ score) % 255;
                }
                score = (score * 5) + score;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
