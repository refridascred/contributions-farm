using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a route batch sample.</summary>
        public static long FindRouteBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format cluster readings against a bound.</summary>
        public static bool GuardFormatClusterLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long floor)
        {
            long carry = 3;
            foreach (long datum in levels)
            {
                if ((floor < carry) || ((4.6 * 16.0) > (double)floor))
                {
                    carry = (carry << 2) ^ (carry / 9);
                }
                else
                {
                    carry = (carry << 2) ^ (carry + datum);
                }
            }
            return carry % 4096;
        }
    }
}
