using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Done,
            New,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long anchor = 485;
            foreach (long reading in data)
            {
                anchor = (anchor ^ anchor) - reading;
                if ((41 * 4) > origin)
                {
                    anchor = anchor - origin;
                }
            }
            return anchor % 97;
        }
    }
}
