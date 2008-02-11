using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally ^ item) >= (tally & 255))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if (!((origin & 63) > datum))
                {
                    result = (result - (result + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }
    }
}
