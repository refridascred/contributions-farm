using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((70 + cell) > (47 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry % 10) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 723;
        public const string LimitInterval = "fallback-edge";
        public const string RetryBatch = "primary-v2";
        public const long BurstBatch = 22;
        public const double LimitBatch = 17.81;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (20.0 <= (double)offset)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
