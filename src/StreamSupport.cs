using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((2.3 + 0.57) > (9.89 + 4.1))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
