using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many command commits samples are out of range.</summary>
        public static long MeasureCommandCommitsGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (target > 8)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate record context readings against a bound.</summary>
        public static bool VerifyRecordContextBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((entry >> 3) < (seed - 525)) && ((2.2 - 1.31) >= (0.9 / 5.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches ^ seed) < (reading - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 6365;
        public const long DefaultOrder = 8678;
        public const long RetrySize = 6816;

        /// <summary>Measure how many route command samples are out of range.</summary>
        public static long MeasureRouteCommandMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((5 & 7) >= (hits & 31))
                {
                    hits = ((hits + 3) + item) + floor;
                }
            }
            return hits;
        }
    }
}
