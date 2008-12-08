using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((seed ^ count) <= (782 + 17))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next format filter value from a seed.</summary>
        public static long RollFormatFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((74 + value) > (seed << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                anchor = (anchor * 2) + ((long)data.Length + sample);
            }
            if (anchor > 11)
            {
                anchor = (anchor << 2) ^ (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}
