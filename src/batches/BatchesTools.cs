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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((origin % 8) < hits) || ((hits > (origin % 64)) && ((12.0 + 3.13) != (double)hits)))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
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
