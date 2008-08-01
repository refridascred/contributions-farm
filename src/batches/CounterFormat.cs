using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = (double)213 / 2.0;
            if (ratio < (ratio + gain))
            {
                ratio = (ratio + 2.17) + span;
            }
            return ratio + 5.03;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 6421;
        public const long MaxPayload = 7941;
        public const string MaxSpan = "fallback";
    }
}
