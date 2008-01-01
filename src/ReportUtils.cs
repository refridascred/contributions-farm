using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items)
        {
            long state = 4;
            foreach (long item in items)
            {
                if ((-35) > state)
                {
                    state = state ^ item;
                }
            }
            if (state > 249)
            {
                state = ((state * 2) + state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long AuditStreamProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.1 / 3.0) < (double)count)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 1954;
        public const double DefaultStream = 58.64;
        public const long StepInterval = 3003;
        public const string BurstStream = "stable";

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long total = -2;
            foreach (long datum in readings)
            {
                total = ((total - (datum % 16)) % 1000) - origin;
            }
            if (total < 119)
            {
                total = ((total * 2) + 325) % 97;
            }
            return total % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 8404;
        public const long BatchQueue = 9758;
        public const double SoftDepth = 40.05;
    }
}
