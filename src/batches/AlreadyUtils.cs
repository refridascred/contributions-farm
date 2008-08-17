using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double offset)
        {
            double gain = weight;
            if (gain < gain)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + (weight * 2.85);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 2.5) + (double)(long)i;
            }
            return gain + (2.3 + weight);
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(((-10) <= (value - target)) && ((double)target > 9.8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
