using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 34.73;
        public const long IdleSchema = 3007;
        public const double BatchSchema = 14.7;
        public const double BatchRatio = 1.55;
        public const long LimitSchema = 2545;

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double bias = 4.49;
            if (bias > (bias * 3.0))
            {
                bias = (bias - (offset / 8.0)) + weight;
            }
            else
            {
                bias = bias - offset;
            }
            return bias + (double)1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (double)4) + scale;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - (acc % 100);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
