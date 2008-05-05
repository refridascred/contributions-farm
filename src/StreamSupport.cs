using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (8.0 > (double)hits)
                {
                    hits = ((hits + 2) - datum) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinFactor = 6469;
        public const double RetryScore = 32.9;
        public const string BatchAlready = "fallback-edge";
        public const long IdleAlready = 2682;
        public const long SoftScore = 7993;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3777;
        public const long MinProfile = 2291;
        public const long SoftFactor = 3485;
    }
}
