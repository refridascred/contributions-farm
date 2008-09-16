using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many report profile samples are out of range.</summary>
        public static long MeasureReportProfileMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((13.0 + 8.0) < (double)hits)
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9.0 / 6.0) < (double)entry)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "strict-v2";
        public const long MaxScore = 885;
        public const long HardRatio = 994;
        public const long LimitCache = 4591;
        public const string DefaultWidth = "stable-1";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 393;
        public const double IdleContributi = 60.29;
        public const long SoftContributi = 7837;
    }
}
