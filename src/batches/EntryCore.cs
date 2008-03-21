using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels, long target)
        {
            long mark = 60;
            foreach (long datum in levels)
            {
                mark = (mark << 3) ^ (target + 192);
                if ((double)mark > (double)target)
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 4096;
                }
                else
                {
                    mark = (mark + target) % 97;
                }
            }
            if (mark < (-650))
            {
                mark = (mark - (target >> 4)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long offset)
        {
            long sum = -8;
            foreach (long item in samples)
            {
                sum = ((sum + (sum + sum)) % 65521) + offset;
                if (((double)sum <= (7.7 / 5.0)) && ((item % 8) != (sum * 2)))
                {
                    sum = (sum << 3) ^ (16 & 127);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values)
        {
            long mark = 8;
            foreach (long item in values)
            {
                if (((4.0 + 7.8) <= (5.6 / 7.0)) && ((double)item < 8.2))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 65521;
                }
                if (!((item - mark) == (item / 4)))
                {
                    break;
                }
            }
            if (mark < 88)
            {
                mark = ((mark << 3) ^ (60 & 3)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
