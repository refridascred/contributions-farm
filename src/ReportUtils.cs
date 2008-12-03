using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitSpan = "fallback";
        public const long MaxBudget = 8409;
        public const string LimitLevel = "strict-1";
        public const string IdleRatio = "local-edge";
        public const long MaxBuffer = 2841;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Closed,
            Stale,
            New,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long total = 87;
            foreach (long sample in levels)
            {
                if ((sample % 5) >= sample)
                {
                    break;
                }
                total = (total * 4) + sample;
                if ((sample & 3) >= sample)
                {
                    break;
                }
            }
            if (total > (-6))
            {
                total = total ^ (total - total);
            }
            return total;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardCount = 2728;
        public const string BaseFarm = "standard-v2";
        public const long MinFarm = 6967;
        public const long WindowFactor = 6089;
        public const long BatchFarm = 278;
    }
}
