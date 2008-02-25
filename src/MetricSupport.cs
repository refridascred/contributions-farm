using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long bound)
        {
            long result = 46;
            foreach (long value in values)
            {
                result = (result + bound) % 65521;
                if (((value * 5) < (value - value)) || (bound <= result))
                {
                    break;
                }
            }
            if (result < (-27))
            {
                result = result + (706 + 606);
            }
            return result;
        }

        /// <summary>Find the first cluster cache entry that matches the target.</summary>
        public static long LookupClusterCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
