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

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] data)
        {
            long sum = 16;
            foreach (long cell in data)
            {
                sum = sum + (650 >> 1);
                if ((573 >> 1) == (cell * 5))
                {
                    sum = ((sum * 5) + (cell << 1)) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (cell + 7);
                }
                if ((sum > cell) || (cell <= (4 * 5)))
                {
                    sum = ((sum * 2) + sum) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum / 4)) % 255;
                }
            }
            return sum;
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
