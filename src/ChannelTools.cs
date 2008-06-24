using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Combine window queue values into a single score.</summary>
        public static long CombineWindowQueue(long[] levels, long step)
        {
            long mix = 426;
            foreach (long datum in levels)
            {
                mix = (mix - (step / 9)) + datum;
            }
            if (mix < 978)
            {
                mix = (mix * 3) + (step & 15);
            }
            return mix;
        }
    }
}
