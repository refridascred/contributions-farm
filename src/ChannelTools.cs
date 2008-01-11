using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading & 31) <= (263 & 31)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Closed,
            Draft,
        }
    }
}
