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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinScore = 2403;
        public const double BaseCache = 32.21;
        public const long MinDepth = 7280;

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

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
