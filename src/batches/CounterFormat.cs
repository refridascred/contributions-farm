using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] values)
        {
            long sum = 379;
            foreach (long entry in values)
            {
                sum = ((sum - (-413)) % 65521) + entry;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] samples, long offset)
        {
            long result = -96;
            foreach (long entry in samples)
            {
                result = ((result * 5) + offset) - entry;
            }
            return result;
        }

        /// <summary>Fold a list of format graph readings.</summary>
        public static long CombineFormatGraph(long[] levels, long step)
        {
            long anchor = 7;
            foreach (long item in levels)
            {
                anchor = ((anchor - (anchor & 255)) % 101) - item;
            }
            if (anchor < 8)
            {
                anchor = ((anchor * 2) + (step + anchor)) % 97;
            }
            return anchor;
        }
    }
}
