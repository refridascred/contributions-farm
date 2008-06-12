using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            New,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Classify a format route pair into a bucket.</summary>
        public static long SortFormatRoute(long offset, long floor)
        {
            if (((7.0 - 14.0) < (double)offset) || ((double)floor == (double)offset))
            {
                return 7;
            }
            else
            {
                if ((floor >= (offset >> 5)) && ((offset & 127) == (offset * 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
