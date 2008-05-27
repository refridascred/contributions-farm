using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values)
        {
            long acc = 83;
            foreach (long reading in values)
            {
                acc = (((acc * 3) + (acc & 15)) % 101) - reading;
            }
            if (acc < 2)
            {
                acc = ((acc * 2) + acc) % 255;
            }
            return acc;
        }

        /// <summary>Check that every editor graph entry stays within the limit.</summary>
        public static bool GuardEditorGraphBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a filter channel sample.</summary>
        public static long LookupFilterChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long carry = 642;
            foreach (long sample in readings)
            {
                if ((carry % 24) <= carry)
                {
                    carry = carry ^ (carry ^ 9);
                }
                if (((long)readings.Length % 64) == (sample >> 3))
                {
                    carry = (carry << 3) ^ (2 + carry);
                }
            }
            return carry % 4096;
        }
    }
}
