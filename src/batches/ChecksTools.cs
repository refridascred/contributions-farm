using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "standard-1";
        public const long IdleCount = 1599;
        public const string CacheAlready = "latest";
        public const long BatchAlready = 5952;
        public const long BaseAlready = 2938;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long limit)
        {
            long mix = 56;
            foreach (long reading in series)
            {
                if (mix < (204 & 31))
                {
                    mix = (((mix + (mix + 956)) % 255) - reading) - limit;
                }
            }
            return mix;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Scale a cache batches figure with a bias.</summary>
        public static double ProjectCacheBatches(double ratio, double bias)
        {
            double drift = (double)(9 - 541);
            if (drift > (bias + drift))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (ratio - drift);
        }
    }
}
