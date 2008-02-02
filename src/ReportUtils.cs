using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            New,
            Paused,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepScore = 5771;
        public const long LimitSpan = 9602;
        public const string BaseDepth = "strict-edge";
        public const long DefaultContext = 5338;
        public const long SoftBudget = 6533;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxCount = 5551;
        public const string WindowDepth = "strict-v2";
        public const string MinContributi = "open-1";
        public const long WindowCount = 855;
    }
}
