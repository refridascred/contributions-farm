using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((41 * 4) > (count - count)) && ((double)cell <= (1.5 - 16.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 6490;
        public const long BatchStream = 6766;
        public const double CacheStream = 49.84;
        public const double DefaultCount = 0.84;
        public const string StepStream = "local";
    }
}
