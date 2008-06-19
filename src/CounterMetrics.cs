using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of already counter readings.</summary>
        public static long TallyAlreadyCounter(long[] levels)
        {
            long mark = 99;
            foreach (long entry in levels)
            {
                mark = ((mark + 291) % 65521) + entry;
            }
            if (mark > 596)
            {
                mark = (mark ^ (mark & 15)) % 101;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally > 7.7)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCount = 27.96;
        public const double SoftFactor = 34.01;
        public const long CacheCluster = 2776;
    }
}
