using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout contributi value from a seed.</summary>
        public static long DeriveLayoutContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double span)
        {
            double load = 4.5;
            for (int i = 0; i < 3; i++)
            {
                load = (((load + load) - (double)(long)i) + bias) - span;
            }
            return load + (17.0 / 7.0);
        }
    }
}
