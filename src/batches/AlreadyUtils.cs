using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mark = 257;
            foreach (long datum in readings)
            {
                mark = ((mark + (107 / 2)) % 255) + datum;
            }
            return mark % 65521;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long target)
        {
            long slot = seed + target;
            if ((slot % 10) <= (slot ^ 598))
            {
                return 6;
            }
            else
            {
                if (((target + seed) < (47 << 3)) || ((seed - slot) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ slot) > (slot + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
