using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report support readings against a bound.</summary>
        public static bool GuardReportSupportBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
