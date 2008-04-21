using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
