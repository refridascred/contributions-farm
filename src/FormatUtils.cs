using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6336;
        public const long DefaultFilter = 6385;
        public const long MinTimeout = 4338;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Idle,
            Queued,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9133;
        public const long HardMetrics = 2903;
        public const long DefaultMetrics = 5336;
        public const double CacheMetrics = 67.55;
        public const double BurstMetrics = 66.34;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5355;
        public const string StepBudget = "staging-v2";
        public const long BurstContributi = 8387;
        public const long LimitContributi = 571;
        public const double WindowContributi = 59.2;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (5.0 / 2.0))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "alpha-v2";
        public const long MinLayout = 2615;
        public const long DefaultDepth = 3950;
        public const string BaseLayout = "alpha-edge";
    }
}
