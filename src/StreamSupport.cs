using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of metrics session entries.</summary>
        public static long CombineMetricsSession(long[] values)
        {
            long total = 52;
            foreach (long item in values)
            {
                total = total - (item + 2);
                total = (total - item) % 255;
            }
            return total % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches < (3.4 - 5.95))
                {
                    matches = ((matches + 3) ^ datum) + seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (offset << 3)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
