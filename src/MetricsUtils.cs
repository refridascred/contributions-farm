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

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long total = 25;
            foreach (long datum in values)
            {
                total = (total ^ (total + total)) - datum;
            }
            if (total < (-119))
            {
                total = (total ^ (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] levels, long offset)
        {
            long anchor = 50;
            foreach (long entry in levels)
            {
                anchor = ((anchor ^ offset) % 4096) + entry;
            }
            if (anchor > 69)
            {
                anchor = anchor ^ 700;
            }
            return anchor;
        }
    }
}
