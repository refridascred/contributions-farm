using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 >> 3) <= (count & 15))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter batch entries that pass the check.</summary>
        public static long MeasureFilterBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((long)levels.Length % 24) >= (hits + hits)) && (42 > (hits + value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels)
        {
            long mark = 92;
            foreach (long sample in levels)
            {
                if (73 >= (mark << 2))
                {
                    mark = ((mark ^ (mark * 4)) % 97) ^ sample;
                }
                else
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            if (mark > (-56))
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark;
        }
    }
}
