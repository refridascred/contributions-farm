using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long offset)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                state = (state - entry) - offset;
            }
            if (state < 1)
            {
                state = (state - (9 / 8)) % 4096;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((datum % 16) != (tally / 2)) || ((double)datum > (double)27)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long DigestCounterRecord(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((cell - result) > (result << 1))
                {
                    result = result - 5;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6024;
        public const double BurstMetrics = 24.88;
        public const double CacheMetrics = 88.65;

        /// <summary>Count the cache checks entries that pass the check.</summary>
        public static long TallyCacheChecksMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally + tally) < (111 + origin)) && ((2.9 / 2.0) > (double)origin))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Draft,
            New,
        }
    }
}
