using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits >= (3.3 / 7.0))
                {
                    hits = ((hits + 1) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((bound > (bound & 1)) && (bound > (-793)))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format stats entry stays within the limit.</summary>
        public static bool CheckFormatStatsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item << 1) > ((long)samples.Length ^ 87)) || ((item + item) <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "primary-edge";
        public const long BatchFarm = 1033;
        public const long SoftFarm = 1100;
        public const string CacheFarm = "alpha-edge";
        public const long MinFarm = 8970;
    }
}
