using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9622;
        public const double MinReport = 90.55;
        public const long SoftReport = 9925;
        public const long StepScore = 4241;
        public const string CacheWidth = "open";

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "staging";
        public const long LimitFilter = 5071;
        public const double RetryInterval = 48.95;

        /// <summary>Check that every stats route entry stays within the limit.</summary>
        public static bool VerifyStatsRouteBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
