using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Retry,
            Idle,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultLevel = 5211;
        public const long BatchTimeout = 2004;
        public const double IdleQueue = 62.45;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (27 >= (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
