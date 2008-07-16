using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 26.87;
        public const long LimitLevel = 1703;
        public const string WindowRatio = "primary-v2";
        public const long MaxOrder = 7524;
        public const long BaseDepth = 1666;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((long)series.Length - count) < 955)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
