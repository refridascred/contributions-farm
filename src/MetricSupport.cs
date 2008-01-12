using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of report profile readings.</summary>
        public static long OverlapReportProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 40.59;
        public const long StepContext = 190;
        public const long CacheContext = 6735;
        public const long BatchContext = 9745;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Draft,
            Idle,
            Done,
        }
    }
}
