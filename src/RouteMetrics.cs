using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (total >> 2)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const long BurstBooking = 1813;
        public const double MaxScore = 68.55;
        public const long DefaultDepth = 1263;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
