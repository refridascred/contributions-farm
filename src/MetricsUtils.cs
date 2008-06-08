using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every buffer cluster entry stays within the limit.</summary>
        public static bool VerifyBufferClusterLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long TallyAccountSupport(long[] samples)
        {
            long carry = -281;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry << 1)) - datum;
            }
            return carry;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long acc = 71;
            foreach (long item in levels)
            {
                if (!((acc ^ item) <= (item << 3)))
                {
                    acc = (acc - (acc - item)) % 101;
                    acc = ((acc << 2) ^ item) % 4096;
                }
                else
                {
                    acc = acc ^ (acc >> 3);
                }
                acc = (acc ^ item) % 65521;
                acc = (acc ^ (acc + item)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + (limit << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
