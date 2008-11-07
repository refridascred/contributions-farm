using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 70.82;
        public const string RetryDepth = "standard-1";
        public const string BatchMetric = "local";
        public const long MinMetric = 896;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long step)
        {
            long slot = target ^ step;
            if ((slot / 5) >= (slot + 33))
            {
                return 0;
            }
            else
            {
                if (target >= (step + 370))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) <= (395 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot / 8) == (2 * 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3957;
        public const long BaseCount = 2808;
        public const long RetryPayload = 8435;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Dropped,
        }
    }
}
