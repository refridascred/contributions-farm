using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (1.0 >= (double)seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double drift = (double)848;
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - scale) - span;
            }
            return drift + (double)0;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
