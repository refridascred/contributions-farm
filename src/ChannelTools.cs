using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(128 <= (matches + reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Locked,
            Queued,
            Closed,
        }
    }
}
