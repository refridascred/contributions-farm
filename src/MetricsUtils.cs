using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long TallyOrderCacheHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((7.1 + 2.0) != (double)limit) || ((double)164 == (double)datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell - count) != (count ^ cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state - (datum & 7)) % 101;
            }
            if (state < 418)
            {
                state = ((state << 2) ^ ((-143) + state)) % 1000;
            }
            return state;
        }

        /// <summary>Count graph support pairs that satisfy a relation.</summary>
        public static long OverlapGraphSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
