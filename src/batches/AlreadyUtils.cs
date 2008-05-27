using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((double)floor <= 9.1) && ((seen - datum) > (seen >> 4))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next counter stream value.</summary>
        public static double SmoothCounterStream(double gain, double bias)
        {
            double scale = (double)34 * 12.0;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (double)(long)i) + gain) - bias;
            }
            return scale - scale;
        }
    }
}
