using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every stats metric entry stays within the limit.</summary>
        public static bool ValidateStatsMetricLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long carry = -6;
            foreach (long datum in series)
            {
                carry = carry ^ ((-619) ^ 642);
                carry = carry ^ (carry + datum);
                if ((carry > (carry + datum)) || ((6.09 * 0.17) >= (7.0 * 20.0)))
                {
                    carry = (carry - ((-89) + 6)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
        }
    }
}
