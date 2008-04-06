using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleLevel = "cached";
        public const double StepScore = 75.47;
        public const long HardRatio = 5249;
        public const long CacheScore = 3811;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) < (datum - target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits report entry stays within the limit.</summary>
        public static bool GuardCommitsReportBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Synced,
            Pending,
        }
    }
}
