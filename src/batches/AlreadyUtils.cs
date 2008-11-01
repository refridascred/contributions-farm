using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = ((long)i << 1) / 3;
                acc = (acc + (lane % 8)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate cluster report samples.</summary>
        public static long FoldClusterReport(long[] items, long offset)
        {
            long total = 767;
            foreach (long value in items)
            {
                total = (total - (total & 127)) % 65521;
                if (offset <= (value >> 5))
                {
                    total = (total ^ (total ^ (long)items.Length)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ value) % 101;
                }
            }
            return total;
        }
    }
}
