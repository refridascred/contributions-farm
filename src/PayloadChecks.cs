using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((62 << 1) == (entry & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series, long seed)
        {
            long score = 7;
            foreach (long cell in series)
            {
                if ((double)cell != (20.0 + 8.8))
                {
                    score = (score ^ (seed ^ 8)) % 65521;
                }
            }
            if (score < 140)
            {
                score = (score * 3) + 5;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "latest-1";
        public const long HardScore = 6988;
        public const string CacheNotes = "cached-1";
        public const long IdleNotes = 1619;
        public const string BaseNotes = "fallback-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3618;
        public const string BaseFactor = "fallback";
        public const double BatchProfile = 80.03;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((bound - matches) >= bound) || ((matches % 10) >= (matches >> 4))) || (((double)9 < (double)bound) && ((value + value) < (bound % 8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
