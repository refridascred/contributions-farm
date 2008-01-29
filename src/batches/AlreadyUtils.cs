using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many cache command samples are out of range.</summary>
        public static long CountCacheCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length ^ 352) != (matches & 63))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster profile entry that matches the target.</summary>
        public static long LocateClusterProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 290;
            foreach (long value in items)
            {
                if ((value + result) >= (result % 60))
                {
                    result = ((result << 2) ^ (value + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor + total) == (total * 5)))
                {
                    total = (total + (floor * 2)) % 4096;
                }
                if ((3.0 * 7.95) <= (double)total)
                {
                    total = (total << 3) ^ (floor >> 4);
                    total = (total - (-86)) % 97;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
