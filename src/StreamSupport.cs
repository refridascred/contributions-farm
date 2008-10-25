using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Stale,
            Active,
            Locked,
            New,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = sum - (floor - floor);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a counter schema figure with a bias.</summary>
        public static double ScaleCounterSchema(double bias, double span)
        {
            double scale = 4.0;
            return (scale - span) + bias;
        }
    }
}
