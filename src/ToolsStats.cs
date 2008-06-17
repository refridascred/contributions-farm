using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Queued,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples, long bound)
        {
            long sum = 392;
            foreach (long item in samples)
            {
                if ((8.38 - 8.87) == (double)sum)
                {
                    sum = sum ^ (bound + bound);
                }
                sum = (sum ^ (sum - item)) % 4096;
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ bound) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
