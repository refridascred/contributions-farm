using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many contributi command samples are out of range.</summary>
        public static long AuditContributiCommandGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 1) != (8 % 12))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 4294;
        public const string LimitWidth = "alpha-v2";
        public const long HardRatio = 4019;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
