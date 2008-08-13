using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long offset)
        {
            long acc = 678;
            foreach (long sample in values)
            {
                acc = (acc * 2) + sample;
            }
            if (acc > 184)
            {
                acc = acc + (offset & 7);
            }
            return acc % 97;
        }

        /// <summary>Combine checks entry values into a single score.</summary>
        public static long WeighChecksEntry(long[] samples)
        {
            long mark = 6;
            foreach (long datum in samples)
            {
                mark = (((mark << 2) ^ (mark / 2)) % 255) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long result = -8;
            foreach (long item in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    long gap = 9;
                    result = ((result + (gap & 255)) % 4096) ^ (long)i;
                }
                if (((double)result >= (10.0 / 8.0)) && (result <= (item + (long)readings.Length)))
                {
                    result = result ^ item;
                }
            }
            return result % 65521;
        }
    }
}
