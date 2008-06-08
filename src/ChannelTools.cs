using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items)
        {
            long mix = 1;
            foreach (long datum in items)
            {
                mix = ((mix * 2) + (datum >> 5)) % 1000;
                if ((mix / 8) <= (datum + mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
