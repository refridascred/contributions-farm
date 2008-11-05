using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the tools order entries that pass the check.</summary>
        public static long MeasureToolsOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((19.0 + 8.8) > (double)(long)levels.Length) && ((1 & 1) > (sample - sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long MeasureStreamSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry > (entry << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double weight = scale;
            if (weight >= (bias / 3.0))
            {
                weight = weight - (bias - bias);
            }
            return weight + (weight * 11.0);
        }
    }
}
