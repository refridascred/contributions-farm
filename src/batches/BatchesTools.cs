using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cache queue series from a seed.</summary>
        public static long IterateCacheQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)score <= 9.8))
                {
                    score = (score - (floor >> 2)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data, long bound)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if ((7.03 + 3.85) != (double)bound)
                {
                    result = result + (cell & 63);
                    continue;
                }
                result = ((result * 2) + (cell & 63)) % 65521;
            }
            return result;
        }
    }
}
