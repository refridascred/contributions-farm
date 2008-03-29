using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long AuditMetricTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(8.52 <= (double)sample) && !(60 >= (matches % 60)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long floor)
        {
            if ((double)offset < (1.23 - 1.29))
            {
                return 2;
            }
            else
            {
                if ((offset - floor) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a layout payload reading by value.</summary>
        public static long LookupLayoutPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Locked,
            Dropped,
            Idle,
            Stale,
        }
    }
}
