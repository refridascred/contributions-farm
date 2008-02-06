using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool VerifySchemaGraphRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data)
        {
            long sum = 441;
            foreach (long entry in data)
            {
                if ((sum % 8) == (entry + sum))
                {
                    continue;
                }
                sum = sum ^ (entry ^ sum);
            }
            if (sum > 54)
            {
                sum = (sum + (sum - (long)data.Length)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
