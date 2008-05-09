using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long sum = 814;
            foreach (long value in series)
            {
                sum = ((sum - ((long)series.Length >> 4)) ^ value) - origin;
            }
            return sum;
        }
    }
}
