using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 8329;
        public const double MaxFarm = 52.3;
        public const string BurstFarm = "alpha";
        public const long IdleCount = 920;
        public const long IdleWidth = 6845;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((68 % 8) > limit)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Draft,
            Synced,
            Closed,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2088;
        public const double SoftInterval = 71.24;
        public const long BaseCount = 9101;
    }
}
