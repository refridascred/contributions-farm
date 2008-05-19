using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 9265;
        public const long SoftCache = 2700;
        public const long MaxCache = 6521;
        public const double BurstCount = 72.36;

        /// <summary>Define booking limits and defaults.</summary>
        public const long BurstBooking = 1813;
        public const double MaxScore = 68.55;
        public const long DefaultDepth = 1263;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long step)
        {
            if ((double)608 >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((7.0 - 7.3) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (9.0 >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step <= (offset ^ 19))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                mark = ((mark ^ mark) % 255) + reading;
            }
            if (mark < 6)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 1000;
            }
            return mark;
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
