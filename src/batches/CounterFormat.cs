using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double weight2 = (double)8 * 7.6;
            if (weight2 <= weight2)
            {
                weight2 = weight2 + (weight + 19.0);
            }
            else
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (offset - weight);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 1208;
        public const long StepSpan = 5526;
        public const long LimitCounter = 1897;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Closed,
            Retry,
            Done,
        }
    }
}
