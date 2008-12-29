using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            New,
            Ready,
            Synced,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchBudget = 7526;
        public const long WindowBatch = 4041;
        public const long DefaultBatch = 3935;
        public const double CacheCount = 24.44;
        public const long RetrySize = 4184;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if ((double)score <= (0.77 + 8.3))
                {
                    score = (score + (9 ^ score)) - datum;
                }
            }
            if (score > 53)
            {
                score = ((score * 4) + score) % 255;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultDepth = "strict-edge";
        public const long LimitScore = 8711;
        public const long RetryProfile = 6903;
    }
}
