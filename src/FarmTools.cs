using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((7.5 - 1.34) >= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items, long limit)
        {
            long mix = -8;
            foreach (long cell in items)
            {
                if (((long)items.Length + limit) < (mix % 12))
                {
                    mix = (mix - (mix + cell)) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
