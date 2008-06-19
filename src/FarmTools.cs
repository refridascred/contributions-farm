using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= (277 - seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

        /// <summary>Measure how many counter metrics samples are out of range.</summary>
        public static long AuditCounterMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum > (8 % 16)) || ((-5) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
