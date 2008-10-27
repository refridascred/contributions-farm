using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double ratio = gain;
            return ratio + (floor - 0.12);
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit already channel readings against a rule.</summary>
        public static long MeasureAlreadyChannelHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((reading / 2) > (reading * 4)) && (hits >= (reading + reading))) || (((reading + hits) > (hits - hits)) && ((reading + reading) < (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
