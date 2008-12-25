using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double bias = offset;
            if (bias > weight)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - (offset + offset);
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if (anchor >= bound)
                {
                    anchor = anchor - (6 + anchor);
                }
                anchor = (anchor * 3) + ((long)i << 2);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
