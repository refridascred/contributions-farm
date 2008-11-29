using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long acc = 47;
            foreach (long item in levels)
            {
                acc = (acc ^ (item - acc)) % 65521;
                if ((item ^ acc) <= (9 % 60))
                {
                    acc = ((acc << 2) ^ (acc - 0)) % 97;
                }
                else
                {
                    acc = acc - ((long)levels.Length >> 4);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long sum = 52;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum ^ sample) % 101) ^ (long)i) + limit;
                    sum = sum ^ sample;
                }
                sum = (sum ^ (long)levels.Length) % 65521;
            }
            return sum;
        }
    }
}
