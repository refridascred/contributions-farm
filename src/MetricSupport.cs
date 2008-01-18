using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardInterval = 9108;
        public const long BaseSize = 8836;
        public const string BatchWindow = "standard-edge";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count / 2) >= (count ^ count))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
