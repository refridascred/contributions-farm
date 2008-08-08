using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data, long floor)
        {
            long sum = 2;
            foreach (long value in data)
            {
                if ((513 & 255) != (value % 5))
                {
                    sum = (((sum << 2) ^ value) % 101) - floor;
                }
            }
            return sum;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((-29) * 4) < (total ^ (long)i))
                {
                    total = (total << 2) ^ (seed ^ (long)i);
                    total = ((total << 2) ^ (total * 3)) % 4096;
                }
                if ((total % 5) > seed)
                {
                    total = (total + seed) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((8.0 - 12.0) >= (double)offset)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
