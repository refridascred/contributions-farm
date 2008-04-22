using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long limit)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                if (13 < limit)
                {
                    mark = (((mark << 2) ^ (mark + limit)) % 65521) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LocateSchemaReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed >> 5) < ((-64) + 90))
                {
                    mix = ((mix * 3) + (seed << 2)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long seed)
        {
            long diff = origin + seed;
            if (9 >= (diff % 24))
            {
                return 1;
            }
            else
            {
                if ((2.5 - 0.72) >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)(-6) <= (double)origin)
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
    }
}
