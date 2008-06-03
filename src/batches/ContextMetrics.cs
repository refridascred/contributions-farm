using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long offset)
        {
            if (((double)offset >= (double)66) || ((5.41 / 8.0) != (double)origin))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (9.88 - 5.6))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length > (double)38)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSpan = 52.13;
        public const long BatchFactor = 5272;
        public const string BatchSchema = "standard";
        public const long CacheSize = 7305;
        public const long BurstCount = 9493;
    }
}
