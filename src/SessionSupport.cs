using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long total = 71;
            foreach (long entry in readings)
            {
                total = total - total;
                if ((entry <= (total - total)) || (338 < (entry % 8)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Done,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
