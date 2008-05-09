using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRatio = "stable-edge";
        public const long BurstRecord = 9306;
        public const double WindowSize = 88.73;
        public const double StepRecord = 77.47;
        public const long CacheWidth = 8454;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen ^ 726) > (datum - seen)) || !(datum >= (seen % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheSpan = "latest-edge";
        public const double MaxInterval = 36.49;
        public const double StepStats = 15.62;
    }
}
