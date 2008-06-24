using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank account cache input into a small class.</summary>
        public static long GradeAccountCache(long bound, long origin)
        {
            if (((origin - 516) != (bound + origin)) && ((bound + 530) != (bound % 60)))
            {
                return 5;
            }
            else
            {
                if ((18.0 - 1.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + (-1)) >= (entry - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Level { get; set; }
        }
    }
}
