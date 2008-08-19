using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long anchor = -927;
            foreach (long entry in values)
            {
                if ((anchor & 3) == (origin << 3))
                {
                    anchor = (anchor * 3) + (entry - anchor);
                }
            }
            return anchor % 4096;
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

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
