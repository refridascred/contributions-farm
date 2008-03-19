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

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
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
