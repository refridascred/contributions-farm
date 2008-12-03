using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - ((long)i ^ bound)) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double ratio = (double)((-375) + 203);
            if (ratio < (double)77)
            {
                ratio = (ratio + weight) + floor;
            }
            return ratio + 5.0;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
