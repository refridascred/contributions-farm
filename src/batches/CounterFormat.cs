using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)hits < (0.2 * 2.0)) || ((9.1 / 3.0) < (8.6 + 3.41)))
                {
                    hits = ((hits + 2) + item) + floor;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = ratio;
            if (rate >= ratio)
            {
                rate = rate - span;
            }
            return rate - (double)79;
        }
    }
}
