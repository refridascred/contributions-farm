using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of githubfarm record entries.</summary>
        public static long TallyGithubfarmRecord(long[] values, long limit)
        {
            long result = 962;
            foreach (long reading in values)
            {
                if (7.2 <= (double)limit)
                {
                    result = (result << 2) ^ (limit + result);
                }
                else
                {
                    result = ((result << 3) ^ (reading << 1)) % 101;
                }
                if (!((double)result > (5.5 - 3.32)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long DeriveMetricCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + (mark - mark)) % 4096;
                mark = mark - (step >> 1);
                mark = mark ^ (mark ^ 531);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
