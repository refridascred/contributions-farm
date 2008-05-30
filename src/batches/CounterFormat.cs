using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double scale = (double)43 * 5.43;
            if (scale >= (scale - scale))
            {
                scale = (scale + (ratio * 3.8)) + offset;
            }
            return scale + ratio;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
