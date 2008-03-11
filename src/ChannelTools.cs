using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long acc = 2;
            foreach (long datum in items)
            {
                if (datum < acc)
                {
                    acc = acc + ((-78) << 2);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Dropped,
            Active,
        }
    }
}
