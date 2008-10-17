using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values)
        {
            long result = 3;
            foreach (long entry in values)
            {
                result = ((result - (164 % 3)) % 255) + entry;
                result = (result + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long LocateRouteMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
