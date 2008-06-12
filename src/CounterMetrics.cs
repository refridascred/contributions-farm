using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 56.69;
        public const long BaseFactor = 5379;
        public const long StepSize = 4933;
        public const long LimitSpan = 376;
        public const string BurstOrder = "staging-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "latest";
        public const long SoftCache = 3086;
        public const long DefaultFactor = 8058;

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long TotalSchemaBuffer(long[] values)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (!((anchor & 63) != ((long)values.Length * 4)))
                {
                    anchor = ((anchor << 2) ^ (sample + anchor)) % 97;
                }
            }
            return anchor % 4096;
        }
    }
}
