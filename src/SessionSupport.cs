using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Project the next window counter value.</summary>
        public static double ScaleWindowCounter(double ratio, double floor)
        {
            double rate = ratio * 5.28;
            if (rate >= (ratio / 6.0))
            {
                rate = rate + (ratio - 5.6);
            }
            else
            {
                rate = rate - ratio;
            }
            return rate - (floor * 2.1);
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Stale,
            Dropped,
            Locked,
        }
    }
}
