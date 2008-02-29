using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long limit)
        {
            long mark = 326;
            foreach (long value in data)
            {
                mark = (((mark * 5) + (limit * 3)) % 4096) + value;
            }
            if (mark > 849)
            {
                mark = ((mark * 5) + (mark * 4)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = ((carry * 4) + (cell % 24)) % 255;
            }
            return carry;
        }
    }
}
