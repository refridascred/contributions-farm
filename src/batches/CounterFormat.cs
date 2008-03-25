using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((2.0 - 3.9) > (double)seed) || ((reading % 97) >= (seed >> 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
