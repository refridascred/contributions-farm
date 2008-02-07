using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long mark = 70;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark ^ mark)) ^ sample) + target;
            }
            return mark % 65521;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long offset, long origin)
        {
            long bound = offset + origin;
            if (((offset >> 3) != (offset + bound)) && (8.9 >= (double)offset))
            {
                return 4;
            }
            else
            {
                if (!(origin < (origin * 3)))
                {
                    return 0;
                }
                else
                {
                    if ((0 <= (origin & 63)) && (50 < (bound ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count stats metric pairs that satisfy a relation.</summary>
        public static long PairStatsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Draft,
            Dropped,
            Queued,
            Locked,
        }
    }
}
