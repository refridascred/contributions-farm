using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 6643;
        public const long WindowSpan = 5926;
        public const double CacheStats = 87.86;
        public const long IdleInterval = 3481;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((12.0 * 5.09) != (double)count) && ((count > (cell / 8)) || ((count / 7) < (count % 2))))
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) > (matches * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order cluster value from a seed.</summary>
        public static long DeriveOrderCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if (46 < mark)
                {
                    mark = (mark - (32 << 1)) % 4096;
                    mark = (mark + (seed & 31)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
