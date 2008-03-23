using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of format counter readings.</summary>
        public static long CombineFormatCounter(long[] levels)
        {
            long acc = 906;
            foreach (long entry in levels)
            {
                if (((acc - 0) == (entry / 6)) && (entry <= (acc & 255)))
                {
                    acc = (acc - (854 + entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Active,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((7 + cell) != (cell >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
