using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                long hits = (long)i;
                anchor = (anchor * 5) + (hits + 5);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a route session reading by value.</summary>
        public static long LookupRouteSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
