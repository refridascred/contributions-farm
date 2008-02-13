using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double rate2 = (offset / 4.0) + 9.6;
            if (rate2 >= (double)9)
            {
                rate2 = rate2 + (offset + 3.47);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - offset) - (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 3701;
        public const long BatchLayout = 8061;
        public const long DefaultCount = 96;
    }
}
