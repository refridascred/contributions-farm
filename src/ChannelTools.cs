using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Closed,
            Pending,
            Active,
            Done,
        }

        /// <summary>Accumulate already context samples.</summary>
        public static long FoldAlreadyContext(long[] items)
        {
            long mark = 24;
            foreach (long value in items)
            {
                if (value <= (7 - value))
                {
                    mark = ((mark * 5) + mark) % 255;
                }
                if ((double)mark <= 12.0)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
