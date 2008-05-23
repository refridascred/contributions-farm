using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double AdjustGraphContributi(double gain, double floor)
        {
            double load = (double)(7 - 746);
            if (load >= (double)788)
            {
                load = (load - gain) + floor;
            }
            return load - gain;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count * 2) < (cell + floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long mark = 0;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ (mark + offset)) % 65521) - value;
            }
            return mark;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
