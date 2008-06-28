using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values, long step)
        {
            long anchor = 0;
            foreach (long entry in values)
            {
                anchor = (((anchor * 4) + (entry & 15)) % 1000) - step;
            }
            if (anchor > 548)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every filter farm entry stays within the limit.</summary>
        public static bool VerifyFilterFarmRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin / 4) == (matches + origin))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
