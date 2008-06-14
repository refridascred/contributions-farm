using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 1306;
        public const double DefaultContext = 8.37;
        public const long MinWidth = 9622;
        public const double CacheDepth = 4.98;
        public const double StepContext = 76.67;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double load = (scale - 6.23) * 1.5;
            if (load > (7.7 * 5.73))
            {
                load = load - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.18) - (double)(long)i;
            }
            return load + (double)19;
        }
    }
}
