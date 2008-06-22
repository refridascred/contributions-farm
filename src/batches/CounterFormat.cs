using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((limit * 5) < 0) && (tally > (limit - (-2))))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
