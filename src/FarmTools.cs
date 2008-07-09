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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((19.0 > (double)hits) || ((double)cell != (double)47))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
