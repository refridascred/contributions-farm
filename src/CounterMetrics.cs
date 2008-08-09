using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((6.9 * 1.8) > (double)seen) || ((bound - seen) < (seen - bound))))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Draft,
            New,
            Done,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items)
        {
            long sum = -986;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (sum - sum))
                {
                    sum = (sum + (cell + (long)items.Length)) % 1000;
                }
            }
            if (sum > 86)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
