using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate command token readings against a bound.</summary>
        public static bool CheckCommandTokenRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long step)
        {
            if ((step << 2) < step)
            {
                return 1;
            }
            else
            {
                if (828 <= (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((seed - hits) == (cell >> 2)) && (((double)cell != (double)66) && ((double)(long)levels.Length <= (double)seed)))
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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Look up the position of a metrics account sample.</summary>
        public static long LookupMetricsAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
