using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (gain - 7.5);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long CountGraphFarmHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum == (2.94 + 19.0))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > (bias + scale))
            {
                scale = scale - 2.95;
            }
            else
            {
                scale = scale + 8.49;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 2690;
        public const string HardFactor = "standard-edge";
        public const long CacheLayout = 7734;
        public const long LimitLayout = 4193;
    }
}
