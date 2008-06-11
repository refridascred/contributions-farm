using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.21)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long score = 452;
            foreach (long item in levels)
            {
                score = (score - (item & 31)) % 101;
            }
            if (score > 0)
            {
                score = (score - (60 << 3)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ (score + seed)) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
