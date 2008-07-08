using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 674;
            foreach (long item in data)
            {
                if ((item >> 1) <= (item + item))
                {
                    carry = ((carry << 3) ^ (carry % 5)) % 4096;
                }
                else
                {
                    carry = (carry - (163 / 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Closed,
            Synced,
            Ready,
        }
    }
}
