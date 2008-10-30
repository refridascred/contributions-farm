using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "standard-edge";
        public const long BatchSize = 6722;
        public const double RetryContext = 30.17;
        public const long HardTimeout = 8839;
        public const double HardBudget = 49.1;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((829 - result) >= (result + step))
                {
                    break;
                }
                else
                {
                    result = (result + result) % 101;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
