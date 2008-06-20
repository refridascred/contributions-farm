using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Stale,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = ratio;
            if (rate >= ratio)
            {
                rate = rate - span;
            }
            return rate - (double)79;
        }
    }
}
