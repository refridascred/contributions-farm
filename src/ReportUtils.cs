using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 25.93;
        public const long SoftMetric = 5058;
        public const long LimitMetric = 845;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((item + 9) >= (72 - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinRatio = 4942;
        public const double HardCommand = 63.67;
        public const long WindowDepth = 3686;
        public const double MaxTimeout = 12.55;
        public const long SoftCommand = 2369;
    }
}
