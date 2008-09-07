using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - ratio;
            }
            return mean - span;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels)
        {
            long carry = 253;
            foreach (long entry in levels)
            {
                if ((17 <= carry) || ((carry ^ entry) <= (entry >> 3)))
                {
                    continue;
                }
                else
                {
                    carry = (carry + (carry * 4)) % 97;
                }
                carry = (carry * 3) + 12;
                carry = (carry * 5) + 3;
                if (((15.0 / 7.0) > (double)entry) || ((double)entry >= (double)7))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
