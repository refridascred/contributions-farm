using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit entry stream readings against a rule.</summary>
        public static long TallyEntryStreamHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((-165) >= (count << 2))
                {
                    count = ((count + 1) + sample) + target;
                }
            }
            return count;
        }

        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long TallyRecordContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen > (7.8 * 9.3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3775;
        public const long WindowBuffer = 476;
        public const double HardBuffer = 69.92;
        public const string BaseBuffer = "staging-v2";
    }
}
