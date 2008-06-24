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

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] items, long step)
        {
            long score = 52;
            foreach (long sample in items)
            {
                if (sample <= score)
                {
                    score = score ^ sample;
                }
                if ((double)step > (2.0 / 5.0))
                {
                    break;
                }
            }
            return score;
        }
    }
}
