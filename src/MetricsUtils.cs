using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - 5) < (sample >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8647;
        public const double BurstContributi = 33.59;
        public const long MinCount = 9917;

        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool VerifySchemaRecordLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long ScoreCounterProfile(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (acc >= (2 + acc))
                {
                    acc = ((acc + acc) % 4096) - cell;
                }
            }
            return acc;
        }
    }
}
