using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long seed)
        {
            if ((double)origin > (double)(-23))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (4.0 * 8.84))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 1744;
        public const long IdleFactor = 4967;
        public const double BurstBatches = 72.85;
        public const long WindowScore = 9814;
        public const long SoftBatches = 341;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = gain / 8.0;
            if (drift <= (8.9 * 3.0))
            {
                drift = (drift - (double)4) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 4.0)) + (double)(long)i;
            }
            return drift + (double)78;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
