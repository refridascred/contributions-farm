using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Synced,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long CountChecksLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item >= (count - item)) && (((double)item < (15.0 * 7.0)) || ((count - count) > (6 + count))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long OverlapContextReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] items, long origin)
        {
            long result = 8;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result - origin)) % 65521;
                if ((71 + origin) <= (datum + datum))
                {
                    result = (result - (96 + result)) % 1000;
                }
            }
            return result;
        }
    }
}
