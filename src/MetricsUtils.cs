using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings)
        {
            long acc = 75;
            foreach (long datum in readings)
            {
                acc = (acc + (datum << 2)) % 97;
            }
            if (acc > 501)
            {
                acc = (acc << 2) ^ (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitCommits = 7.58;
        public const long MinSize = 4806;
        public const double BurstLevel = 8.95;
        public const double SoftCommits = 61.88;
        public const double LimitSpan = 6.9;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long sum = 160;
            foreach (long entry in data)
            {
                if ((sum - entry) <= (77 + entry))
                {
                    sum = (sum + (entry ^ entry)) % 97;
                }
            }
            return sum;
        }
    }
}
