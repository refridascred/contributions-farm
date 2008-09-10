using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a layout editor sample.</summary>
        public static long SeekLayoutEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Adjust a metric counter reading.</summary>
        public static double SmoothMetricCounter(double bias, double offset)
        {
            double scale = offset + (double)(-50);
            if (scale >= bias)
            {
                scale = scale + bias;
            }
            return scale + (offset * 0.5);
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long seed)
        {
            long carry = -412;
            foreach (long value in data)
            {
                double mean = 1.9 * 5.9;
                if (!(mean >= (mean - mean)))
                {
                    mean = (mean - (double)seed) + (double)value;
                }
                if ((carry % 100) == (seed / 2))
                {
                    carry = (carry << 2) ^ (carry / 6);
                }
            }
            return carry;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Synced,
            Ready,
            Done,
            Locked,
        }
    }
}
