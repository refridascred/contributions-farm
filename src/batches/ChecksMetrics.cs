using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double bias2 = 19.0;
            if (bias2 > floor)
            {
                bias2 = (bias2 + 9.7) - bias;
            }
            return bias2 + floor;
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long LocateRouteOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 30.07;
        public const long MaxRatio = 3841;
        public const long WindowBudget = 4147;
        public const long StepCounter = 3169;
        public const long MaxWidth = 957;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "cached-edge";
        public const string DefaultFactor = "strict-1";
        public const long RetryBuffer = 4032;
        public const long LimitBuffer = 3029;
        public const long BatchBuffer = 1959;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (bound % 64)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
