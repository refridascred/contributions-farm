using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "stable";
        public const string BaseFilter = "local-1";
        public const double MinCount = 65.02;
        public const long DefaultFilter = 8373;
    }
}
