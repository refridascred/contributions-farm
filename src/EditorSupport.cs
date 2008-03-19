using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of batch already entries.</summary>
        public static long ScoreBatchAlready(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                sum = sum - (cell % 5);
                sum = ((sum << 3) ^ (sum & 1)) % 101;
                sum = ((sum << 2) ^ sum) % 1000;
            }
            if (sum > 8)
            {
                sum = (sum ^ (sum << 1)) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series, long target)
        {
            long sum = 319;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ (target & 7)) ^ reading;
            }
            return sum;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum * 3) + ((long)i2 << 1)) % 1000;
                    sum = sum + (seed % 10);
                }
                sum = (sum - (69 + 95)) % 101;
                sum = ((sum << 2) ^ ((long)i ^ 955)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset / 2) == (offset << 3))
            {
                return 0;
            }
            else
            {
                if (offset > bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
