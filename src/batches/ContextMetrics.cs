using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepBudget = 56.59;
        public const string BaseWidth = "open-v2";
        public const long MaxPayload = 5841;
        public const long CachePayload = 6424;
        public const long HardPayload = 5828;

        /// <summary>Check that every contributi queue entry stays within the limit.</summary>
        public static bool CheckContributiQueueLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((95 > offset) && ((value << 2) != (offset ^ offset))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowFactor = 69.62;
        public const long BatchMetrics = 5437;
        public const string MaxMetrics = "latest-edge";

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long PairStatsContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
