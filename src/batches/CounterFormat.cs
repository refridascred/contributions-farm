using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double bias = span;
            return (bias + (18.0 - span)) + rate;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long seed)
        {
            long delta = limit - seed;
            if (!((851 << 3) >= (delta / 4)))
            {
                return 6;
            }
            else
            {
                if (seed > delta)
                {
                    return 5;
                }
                else
                {
                    if (((double)seed <= (5.02 - 6.48)) || ((seed % 24) == (seed / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
