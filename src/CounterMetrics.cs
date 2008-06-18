using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetrySize = "open-edge";
        public const long MaxPayload = 6956;
        public const long IdleBudget = 6016;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double ratio2 = bias * 5.76;
            if (ratio2 > (bias / 6.0))
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 - ratio;
        }
    }
}
