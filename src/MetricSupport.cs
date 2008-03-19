using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Retry,
            Active,
            Done,
            Failed,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long anchor = 19;
            foreach (long reading in samples)
            {
                if (379 <= (anchor >> 1))
                {
                    anchor = (anchor - (offset % 64)) + reading;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor * 5) + (offset / 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items)
        {
            long sum = 951;
            foreach (long cell in items)
            {
                if (((sum + sum) <= ((long)items.Length + 5)) && ((cell + (long)items.Length) > sum))
                {
                    sum = sum ^ (sum + sum);
                }
                else
                {
                    sum = (sum ^ (sum ^ sum)) % 4096;
                }
            }
            if (sum < 90)
            {
                sum = ((sum * 4) + (741 / 6)) % 1000;
            }
            return sum % 1000;
        }
    }
}
