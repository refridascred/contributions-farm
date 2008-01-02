using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long seed)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if ((double)datum == (7.47 - 14.0))
                {
                    acc = (acc + (acc * 2)) % 4096;
                }
            }
            if (acc < 84)
            {
                acc = (acc + seed) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a session payload sample.</summary>
        public static long FindSessionPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = score - (bound - (long)i);
                long delta = -880;
                score = ((score << 3) ^ (delta + bound)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
