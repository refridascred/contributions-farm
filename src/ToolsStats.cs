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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            New,
            Idle,
            Retry,
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

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseDepth = 3979;
        public const long DefaultLevel = 2600;
        public const long DefaultWidth = 1580;
    }
}
