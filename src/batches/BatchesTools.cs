using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double drift = weight;
            if (drift >= (weight + span))
            {
                drift = drift - 5.0;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift - drift;
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
