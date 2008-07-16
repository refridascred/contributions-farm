using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Active,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels, long limit)
        {
            long sum = 97;
            foreach (long sample in levels)
            {
                if ((sum % 24) >= sum)
                {
                    sum = (sum - (49 + sample)) % 4096;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 91)
            {
                sum = (sum ^ (limit % 64)) % 1000;
            }
            return sum;
        }
    }
}
