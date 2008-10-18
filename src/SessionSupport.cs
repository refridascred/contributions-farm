using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long bound)
        {
            long total = -67;
            foreach (long entry in levels)
            {
                total = (total + ((long)levels.Length & 7)) % 1000;
                total = total ^ (entry << 3);
            }
            if (total < (-9))
            {
                total = (total + (bound ^ bound)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
