using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double rate = offset;
            return (rate + (double)466) + bias;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state - (origin % 60);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
