using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long IterateBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 8) != (total << 1))
                {
                    total = (total * 3) + ((long)i - offset);
                }
                total = ((total << 2) ^ total) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings, long offset)
        {
            long anchor = 88;
            foreach (long value in readings)
            {
                if ((value & 127) != (offset + anchor))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "latest-edge";
        public const string DefaultWidth = "latest-edge";
        public const string LimitEditor = "strict-1";

        /// <summary>Locate a order notes reading by value.</summary>
        public static long LookupOrderNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long target)
        {
            if ((target + 8) != (178 + limit))
            {
                return 7;
            }
            else
            {
                if (limit >= (2 / 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
