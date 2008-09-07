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

        /// <summary>Combine schema route values into a single score.</summary>
        public static long FoldSchemaRoute(long[] samples)
        {
            long total = 98;
            foreach (long item in samples)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
                if (!((total + total) <= total))
                {
                    total = total - (total + item);
                }
                if (item < ((long)samples.Length >> 3))
                {
                    break;
                }
            }
            if (total < 47)
            {
                total = (total ^ (total << 1)) % 4096;
            }
            return total % 4096;
        }
    }
}
