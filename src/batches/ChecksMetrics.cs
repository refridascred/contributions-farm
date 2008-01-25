using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cluster command readings.</summary>
        public static long MatchClusterCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long mark = 36;
            foreach (long item in samples)
            {
                if ((item - item) < (item * 2))
                {
                    mark = (mark ^ (item % 8)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long origin)
        {
            long anchor = 204;
            foreach (long cell in series)
            {
                if ((origin ^ origin) < cell)
                {
                    anchor = ((anchor << 3) ^ (cell ^ 637)) % 1000;
                }
                else
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
