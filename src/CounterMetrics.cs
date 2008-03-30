using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long SeriesCounterFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardLevel = "legacy";
        public const double StepSize = 73.05;
        public const long DefaultOrder = 5223;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Locked,
            Done,
            Paused,
        }
    }
}
