using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((-7) ^ value) >= (count + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 63) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
