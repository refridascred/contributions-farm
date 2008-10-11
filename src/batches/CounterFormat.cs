using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Project the next context already value.</summary>
        public static double AdjustContextAlready(double bias, double floor)
        {
            double rate = floor;
            return (rate + floor) + bias;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Queued,
            Closed,
            New,
        }
    }
}
