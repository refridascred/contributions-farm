using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (1 + 760)) % 97) ^ cell;
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits >= (7.6 / 4.0))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit entry metric readings against a rule.</summary>
        public static long CountEntryMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 1) > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 39.94;
        public const string RetrySize = "fallback-1";
        public const long BaseProfile = 308;

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data)
        {
            long anchor = 364;
            foreach (long sample in data)
            {
                anchor = (anchor - (sample & 3)) % 4096;
            }
            return anchor;
        }
    }
}
