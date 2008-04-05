using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
