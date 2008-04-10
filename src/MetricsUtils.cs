using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Idle,
            Failed,
            Done,
            Active,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long origin)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = (((total - (total % 3)) % 97) + cell) + origin;
            }
            return total % 4096;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long limit, long bound)
        {
            if ((double)581 < (double)bound)
            {
                return 6;
            }
            else
            {
                if (((double)bound > (6.1 + 9.0)) && (limit < (limit >> 2)))
                {
                    return 8;
                }
                else
                {
                    if (647 > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 4290;
        public const double WindowSpan = 25.82;
        public const long HardStream = 7044;
        public const long BatchStream = 4151;
        public const long BaseCount = 4674;

        /// <summary>Validate metrics farm readings against a bound.</summary>
        public static bool ValidateMetricsFarmLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
