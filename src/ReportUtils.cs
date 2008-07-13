using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool ValidateSchemaRouteRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "open-edge";
        public const long RetryDepth = 4155;
        public const string HardBudget = "primary-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitInterval = 2.84;
        public const long MaxSize = 500;
        public const string WindowTimeout = "strict";
        public const double CacheMetric = 89.5;
        public const long WindowLevel = 3945;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading * 2) != (step + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
