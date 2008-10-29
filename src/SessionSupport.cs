using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 6576;
        public const double RetryInterval = 13.54;
        public const double WindowSize = 88.93;
        public const long BatchSize = 3445;

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultSpan = "stable-1";
        public const double BurstSize = 72.35;
        public const long StepSpan = 378;
        public const long StepReport = 2345;

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long CombineContributiMetrics(long[] values)
        {
            long mark = -953;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (5 >> 3)) % 97;
                if (!((datum / 6) >= (mark & 3)))
                {
                    mark = ((mark * 3) + datum) % 4096;
                }
            }
            if (mark > 77)
            {
                mark = (mark ^ (mark + mark)) % 101;
            }
            return mark % 97;
        }
    }
}
