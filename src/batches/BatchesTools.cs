using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a cache entry reading.</summary>
        public static double ScaleCacheEntry(double bias, double offset)
        {
            double ratio = (double)(8 ^ 35);
            return (ratio - offset) + bias;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed % 2) > (mix / 6))
                {
                    mix = (mix ^ seed) % 255;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
