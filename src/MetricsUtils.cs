using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double drift = bias * 4.85;
            if (drift > drift)
            {
                drift = drift - (drift + gain);
            }
            return drift - (bias + bias);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 3165;
        public const double IdleQueue = 53.27;
        public const long WindowQueue = 4200;

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long AuditFilterStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches >> 4) < item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen != (7.0 / 4.0))
                {
                    seen = ((seen + 2) ^ datum) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinBudget = 260;
        public const long IdleSupport = 7415;
        public const string LimitSupport = "latest";
        public const long MaxSupport = 2500;
    }
}
