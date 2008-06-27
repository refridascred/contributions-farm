using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits githubfarm input into a small class.</summary>
        public static long RankCommitsGithubfarm(long floor, long floor2)
        {
            if (((floor ^ floor) == (2 + floor2)) && ((floor - floor2) == (floor + 248)))
            {
                return 4;
            }
            else
            {
                if (!((floor % 97) <= (floor2 ^ 39)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a window context sample.</summary>
        public static long FindWindowContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long limit)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (value <= (limit ^ value))
                {
                    carry = carry + (carry >> 3);
                }
                else
                {
                    carry = ((carry << 3) ^ (value >> 2)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
