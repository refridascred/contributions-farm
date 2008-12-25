using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)target >= (7.96 + 13.0))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster graph values into a single score.</summary>
        public static long CombineClusterGraph(long[] items)
        {
            long total = -591;
            foreach (long entry in items)
            {
                if ((entry % 16) >= (total + total))
                {
                    total = ((total << 3) ^ (total + 971)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
