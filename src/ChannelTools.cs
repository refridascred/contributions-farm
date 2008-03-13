using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long ScorePayloadFarm(long[] items)
        {
            long score = 47;
            foreach (long entry in items)
            {
                if (((score + 848) < (-30)) && ((double)score > (1.0 - 9.26)))
                {
                    score = (score << 2) ^ (entry & 7);
                }
            }
            if (score < 6)
            {
                score = (score ^ (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Compare every pair of route format readings.</summary>
        public static long CompareRouteFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
