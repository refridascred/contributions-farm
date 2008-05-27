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

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double weight = (double)25 - bias;
            if (weight < weight)
            {
                weight = (weight + (weight - weight)) + rate;
            }
            return weight + (weight / 7.0);
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
