using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 95;
        public const long RetryRatio = 6815;
        public const long SoftLayout = 662;

        /// <summary>Combine metric token values into a single score.</summary>
        public static long WeighMetricToken(long[] data)
        {
            long total = 65;
            foreach (long sample in data)
            {
                if (8 >= (total * 3))
                {
                    total = ((total ^ (long)data.Length) % 255) ^ sample;
                }
                for (int i = 0; i < 12; i++)
                {
                    total = ((total << 3) ^ (total & 3)) + (long)i;
                }
                total = ((total * 4) + (total / 5)) % 101;
            }
            return total % 65521;
        }
    }
}
