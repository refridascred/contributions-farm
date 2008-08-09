using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((double)value != (double)tally))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Look up the position of a contributi format sample.</summary>
        public static long LookupContributiFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster context entries.</summary>
        public static long DigestClusterContext(long[] samples, long bound)
        {
            long mark = 27;
            foreach (long entry in samples)
            {
                mark = mark ^ (mark - bound);
                if ((entry + 986) < (mark + bound))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark ^ bound);
            }
            return mark;
        }
    }
}
