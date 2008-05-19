using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many checks contributi samples are out of range.</summary>
        public static long AuditChecksContributiMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 6) <= (count - (-27)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes filter entry stays within the limit.</summary>
        public static bool GuardNotesFilterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9762;
        public const string StepInterval = "primary-1";
        public const long SoftToken = 4137;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7313;
        public const long CacheRatio = 8674;
        public const string SoftLevel = "fallback-edge";

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series)
        {
            long mark = 412;
            foreach (long entry in series)
            {
                double rate = (4.1 - 9.2) * 7.4;
                if (rate >= (double)entry)
                {
                    mark = mark - (mark ^ entry);
                }
                else
                {
                    mark = (mark - entry) % 97;
                }
                if (mark <= (mark / 4))
                {
                    mark = mark + (mark - mark);
                }
            }
            return mark;
        }
    }
}
