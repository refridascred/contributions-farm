using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long mark = 75;
            foreach (long value in values)
            {
                if (mark > (value * 3))
                {
                    mark = (mark - (mark & 1)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double rate = (floor * 12.0) / 3.0;
            return (rate + floor) + ratio;
        }
    }
}
