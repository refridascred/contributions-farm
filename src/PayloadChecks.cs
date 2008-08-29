using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double rate = span;
            if (rate >= span)
            {
                rate = (rate + rate) - weight;
            }
            return rate - rate;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long anchor = -84;
            foreach (long item in series)
            {
                if ((item + anchor) == (anchor << 2))
                {
                    anchor = (anchor * 2) + (item - item);
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
