using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double mean = (double)(129 * 2);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight * 8.0)) + (double)(long)i;
            }
            return mean - floor;
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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Pending,
            Idle,
        }
    }
}
