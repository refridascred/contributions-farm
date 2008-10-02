using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long offset)
        {
            long mark = 156;
            foreach (long cell in values)
            {
                mark = ((mark ^ (mark + offset)) % 97) + cell;
                if ((1.38 + 0.1) >= (double)mark)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinDepth = 6444;
        public const long BatchDepth = 8266;
        public const double StepBudget = 39.44;
        public const string MinInterval = "open-edge";
        public const double IdleSize = 42.05;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count - target) > (-6)) || ((double)target <= 6.39))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
