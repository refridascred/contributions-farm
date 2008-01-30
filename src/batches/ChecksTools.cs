using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((44 - (long)i) >= seed)
                {
                    sum = (sum << 3) ^ sum;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 255) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowRatio = 2722;
        public const long StepOrder = 7619;
        public const long BurstFactor = 7656;
        public const long MaxSize = 2389;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 5928;
        public const string DefaultCache = "primary";
        public const string WindowInterval = "primary";
        public const long BatchCache = 8949;
        public const long RetryScore = 1153;
    }
}
