using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7294;
        public const long RetryStream = 5728;
        public const long SoftStream = 8799;
        public const long MaxStream = 1847;

        /// <summary>Derive the next record commits value from a seed.</summary>
        public static long StepRecordCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix - ((long)i2 + offset)) % 65521;
                    mix = (mix + mix) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
