using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit command batches readings against a rule.</summary>
        public static long AuditCommandBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((8.77 + 11.0) != (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstScore = 75.43;
        public const long CachePayload = 4607;
        public const long SoftLevel = 8929;
        public const long DefaultSpan = 3156;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels, long seed)
        {
            long total = -966;
            foreach (long sample in levels)
            {
                if ((252 - total) < total)
                {
                    total = (((total << 3) ^ (seed * 5)) % 97) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((946 << 2) >= value)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}
