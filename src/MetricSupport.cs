using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many window notes samples are out of range.</summary>
        public static long MeasureWindowNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + 9) != (value ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 84.74;
        public const long BatchFilter = 7304;
        public const long BatchSize = 7386;
    }
}
