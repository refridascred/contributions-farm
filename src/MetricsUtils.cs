using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.52 - 3.3) <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate format report readings against a bound.</summary>
        public static bool CheckFormatReportLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 5977;
        public const long LimitDepth = 6850;
        public const long WindowRatio = 5475;
        public const long MaxEntry = 1210;
    }
}
